"""Persist validated managed match results and expose the recovered ranking contracts."""
import math
import struct
import time
import server_v4 as core

TICKS_EPOCH = 621355968000000000

class ManagedResults:
    def __init__(self, store):
        self.store = store
        with store._lock, store._db:
            store._db.executescript("""
CREATE TABLE IF NOT EXISTS managed_rank_stats (
 uid INTEGER NOT NULL REFERENCES accounts(uid), mode INTEGER NOT NULL,
 points INTEGER NOT NULL DEFAULT 1000, wins INTEGER NOT NULL DEFAULT 0,
 losses INTEGER NOT NULL DEFAULT 0, draws INTEGER NOT NULL DEFAULT 0,
 PRIMARY KEY(uid,mode), CHECK(mode IN (0,1)));
CREATE TABLE IF NOT EXISTS managed_match_results (
 game_id TEXT PRIMARY KEY, mode INTEGER NOT NULL, winner INTEGER NOT NULL,
 duration INTEGER NOT NULL, completed_at INTEGER NOT NULL,
 competitive INTEGER NOT NULL, payload BLOB NOT NULL);
CREATE TABLE IF NOT EXISTS managed_match_members (
 game_id TEXT NOT NULL REFERENCES managed_match_results(game_id),
 uid INTEGER NOT NULL REFERENCES accounts(uid), hero INTEGER NOT NULL,
 slot INTEGER NOT NULL, PRIMARY KEY(game_id,uid));
""")

    def stats(self, uid):
        result = {}
        with self.store._lock:
            for mode in (0, 1):
                row = self.store._db.execute("""
SELECT points,wins,losses,draws,position FROM (
 SELECT uid,points,wins,losses,draws,
 ROW_NUMBER() OVER(ORDER BY points DESC,wins DESC,uid ASC) AS position
 FROM managed_rank_stats WHERE mode=?) WHERE uid=?""", (mode, uid)).fetchone()
                result[mode] = tuple(int(x) for x in row) if row else (0, 0, 0, 0, 0)
        return result

    def leaderboard(self, payload):
        if len(payload) != 1 or payload[0] not in (0, 1):
            raise ValueError("Invalid ranking mode")
        with self.store._lock:
            rows = self.store._db.execute("""
SELECT a.nickname,s.points FROM managed_rank_stats s JOIN accounts a ON a.uid=s.uid
WHERE s.mode=? ORDER BY s.points DESC,s.wins DESC,s.uid ASC LIMIT 100""", (payload[0],)).fetchall()
        # The original UI maps this byte through rank-position thresholds.
        return struct.pack("<H", len(rows)) + b"".join(
            core.encode_text(name) + struct.pack("<Bi", index + 1, points)
            for index, (name, points) in enumerate(rows))

    def settle(self, room, peers, payload, duration, competitive):
        if len(payload) < 9:
            raise ValueError("Truncated match result")
        winner, kills0, kills1 = struct.unpack_from("<Bii", payload)
        if winner not in (0, 1, 2) or min(kills0, kills1) < 0:
            raise ValueError("Invalid match outcome")
        by_slot = {p.visual.slot: p for p in peers}
        cursor, entries = 9, []
        item_count = 8 if room.mode == 10 else 5
        canonical = bytearray(struct.pack("<Bii", winner, kills0, kills1))
        for slot in range(room.capacity):
            if cursor >= len(payload) or payload[cursor] not in (0, 1):
                raise ValueError("Invalid result presence flag")
            present = payload[cursor]
            cursor += 1
            peer = by_slot.get(slot)
            if bool(present) != (peer is not None):
                raise ValueError("Result roster differs from authenticated participants")
            canonical += bytes((present,))
            if not present:
                continue
            device, hero = struct.unpack_from("<IH", payload, cursor)
            cursor += 6
            nickname, cursor = core.decode_text(payload, cursor)
            guild, level, kills, deaths, assists, minions, activity = struct.unpack_from("<IBHHHHB", payload, cursor)
            cursor += struct.calcsize("<IBHHHHB")
            items = struct.unpack_from("<" + str(item_count) + "H", payload, cursor)
            cursor += 2 * item_count
            if device != peer.device_id or hero != peer.visual.hero_id or level == 0:
                raise ValueError("Result player identity does not match the room")
            account = self.store.get_or_create(device)
            canonical += struct.pack("<IH", device, hero) + core.encode_text(account.nickname)
            canonical += struct.pack("<IBHHHHB" + str(item_count) + "H", 0, level, kills, deaths, assists, minions, activity, *items)
            entries.append((account.uid, hero, slot))
        if cursor != len(payload):
            raise ValueError("Unexpected result bytes")
        game_id = str(room.shared_game_id)
        canonical = bytes(canonical)
        competitive = bool(competitive and {slot % 2 for _, _, slot in entries} == {0, 1})
        mode = 1 if room.mode == 20 else 0
        with self.store._lock, self.store._db:
            old = self.store._db.execute(
                "SELECT payload FROM managed_match_results WHERE game_id=?", (game_id,)).fetchone()
            if old:
                if bytes(old[0]) != canonical:
                    raise ValueError("Conflicting duplicate match result")
                return bytes(old[0])
            self.store._db.execute("INSERT INTO managed_match_results VALUES(?,?,?,?,?,?,?)",
                                   (game_id, room.mode, winner, max(0, int(duration)),
                                    int(time.time()), int(competitive), canonical))
            self.store._db.executemany("INSERT INTO managed_match_members VALUES(?,?,?,?)",
                                       [(game_id, uid, hero, slot) for uid, hero, slot in entries])
            if competitive:
                ratings = {}
                for uid, _, slot in entries:
                    self.store._db.execute(
                        "INSERT OR IGNORE INTO managed_rank_stats(uid,mode) VALUES(?,?)", (uid, mode))
                    ratings[uid] = self.store._db.execute(
                        "SELECT points FROM managed_rank_stats WHERE uid=? AND mode=?", (uid, mode)).fetchone()[0]
                teams = {team: [ratings[uid] for uid, _, slot in entries if slot % 2 == team] for team in (0, 1)}
                averages = {team: sum(values) / len(values) for team, values in teams.items()}
                for uid, _, slot in entries:
                    team = slot % 2
                    actual = 0.5 if winner == 2 else float(winner == team)
                    difference = max(-4000.0, min(4000.0, averages[1-team] - averages[team]))
                    expected = 1.0 / (1.0 + math.pow(10.0, difference / 400.0))
                    points = max(0, min(2147483647, ratings[uid] + round(32 * (actual - expected))))
                    self.store._db.execute("""
UPDATE managed_rank_stats SET points=?,wins=wins+?,losses=losses+?,draws=draws+?
WHERE uid=? AND mode=?""", (points, int(actual == 1), int(actual == 0), int(actual == 0.5), uid, mode))
        return canonical

    def result(self, device, payload):
        if len(payload) != 19:
            raise ValueError("Invalid result lookup")
        game, hero = struct.unpack_from("<QH", payload)
        account = self.store.get_or_create(device)
        with self.store._lock:
            row = self.store._db.execute("""
SELECT r.duration,r.completed_at,m.hero FROM managed_match_results r
JOIN managed_match_members m ON m.game_id=r.game_id
WHERE r.game_id=? AND m.uid=?""", (str(game), account.uid)).fetchone()
        if row is None or hero != row[2]:
            raise ValueError("No settled result for this participant")
        ranks = self.stats(account.uid)
        r0, r1 = ranks[0], ranks[1]
        # Rewards remain zero until the original reward rules are recovered.
        out = struct.pack("<iIqqB", row[0], 0, 0, 0, 0)
        out += struct.pack("<BIq", account.level, account.exp, account.gold)
        out += struct.pack("<IIII", r0[1], r0[2], r1[1], r1[2])
        out += struct.pack("<BiI", min(r0[4], 255), r0[0], r0[4])
        out += struct.pack("<BiI", min(r1[4], 255), r1[0], r1[4])
        out += struct.pack("<iBq", 0, 0, TICKS_EPOCH + row[1] * 10000000)
        assert len(out) == 85
        return out
