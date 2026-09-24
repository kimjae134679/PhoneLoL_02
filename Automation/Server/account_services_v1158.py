"""Original device-account/profile/rune/community routes; battle routing is unchanged."""
from __future__ import annotations
import re, struct, threading, time, secrets
import server_v4 as core
from managed_results_v1168 import ManagedResults
from original_profile_contract import OriginalP4Profile, build_p4_profile
from original_game_contract import build_p7_rune_inventory, parse_rune_mutation, build_rune_page_response, UPPER_RUNE_QUANTITIES

RPC_GET, RPC_RESULT = 64, 65
RPC_HEADER = struct.Struct("<BH")
NICK = re.compile(r"^[a-zA-Z0-9\uac00-\ud7a3]{2,10}$")
OWNED = dict(UPPER_RUNE_QUANTITIES)
TICKS_EPOCH = 621355968000000000

class AccountServices:
    def __init__(self, state):
        self.state = state
        self.store = state.accounts
        self.results = ManagedResults(self.store)
        self.presence = {}
        self.presence_state = {}
        self.events = {}
        self.invites = {}
        self.pending_joins = {}
        self.lock = threading.RLock()
        with self.store._lock, self.store._db:
            self.store._db.executescript("""
CREATE TABLE IF NOT EXISTS account_restore_state (
 uid INTEGER PRIMARY KEY REFERENCES accounts(uid),
 rename_ticks INTEGER NOT NULL DEFAULT 0,
 runes_migrated INTEGER NOT NULL DEFAULT 0);
CREATE TABLE IF NOT EXISTS account_friends (
 requester INTEGER NOT NULL REFERENCES accounts(uid),
 recipient INTEGER NOT NULL REFERENCES accounts(uid),
 accepted INTEGER NOT NULL DEFAULT 0 CHECK(accepted IN (0,1)),
 PRIMARY KEY(requester,recipient), CHECK(requester<>recipient));
""")

    def account(self, device):
        a = self.store.get_or_create(device)
        with self.store._lock, self.store._db:
            self.store._db.execute("INSERT OR IGNORE INTO account_restore_state(uid) VALUES(?)", (a.uid,))
        return a

    def profile(self, device):
        a = self.account(device)
        rank = self.results.stats(a.uid)
        r0, r1 = rank[0], rank[1]
        body = bytearray(build_p4_profile(OriginalP4Profile(
            user_id=device, nickname=a.nickname, level=a.level, exp=a.exp, coin=a.gold,
            tier_3v3=min(r0[4],255), tier_1v1=min(r1[4],255),
            ranking_3v3=r0[4], ranking_1v1=r1[4],
            win_3v3=r0[1], loss_3v3=r0[2], win_1v1=r1[1], loss_1v1=r1[2])))
        score_offset = 27 + len(a.nickname.encode("utf-8"))
        struct.pack_into("<i", body, score_offset, r0[0])
        struct.pack_into("<i", body, score_offset + 8, r1[0])
        with self.store._lock:
            ticks = self.store._db.execute("SELECT rename_ticks FROM account_restore_state WHERE uid=?", (a.uid,)).fetchone()[0]
        struct.pack_into("<q", body, len(body)-9, ticks)
        return bytes(body)

    def nickname(self, device, payload):
        a = self.account(device)
        name, end = core.decode_text(payload)
        if end != len(payload) or not NICK.fullmatch(name):
            return b"\x03"
        with self.store._lock, self.store._db:
            row = self.store._db.execute("SELECT * FROM accounts WHERE uid=?", (a.uid,)).fetchone()
            other = self.store._db.execute("SELECT uid FROM accounts WHERE nickname=?", (name,)).fetchone()
            if other is not None and other[0] != a.uid:
                return b"\x03"
            # Nickname changes are free and have no cooldown by user policy.
            price = 0
            ticks = int(time.time()*10000000)+TICKS_EPOCH
            self.store._db.execute("UPDATE accounts SET nickname=?,gold=gold-?,updated_at=? WHERE uid=?",
                                   (name, price, int(time.time()), a.uid))
            self.store._db.execute("UPDATE account_restore_state SET rename_ticks=? WHERE uid=?", (ticks,a.uid))
            self.store._db.execute("INSERT INTO account_events(device_id,event_type,detail,created_at) VALUES(?,?,?,?)",
                                   (device,"nickname_changed",name,int(time.time())))
            gold = row["gold"]-price
        return b"\0"+core.encode_text(name)+struct.pack("<qq",gold,ticks)

    def runes(self, device, pid, payload):
        a = self.account(device)
        with self.store._lock, self.store._db:
            if pid == 7:
                if payload:
                    if len(payload)!=120: raise ValueError("invalid migration")
                    values = struct.unpack("<60H", payload)
                    if any(v and v not in OWNED for v in values): raise ValueError("unknown rune")
                    migrated=self.store._db.execute("SELECT runes_migrated FROM account_restore_state WHERE uid=?", (a.uid,)).fetchone()[0]
                    existing=self.store._db.execute("SELECT 1 FROM equipped_runes WHERE device_id=? LIMIT 1",(device,)).fetchone()
                    # Existing server data wins; import old local pages at most once.
                    if not migrated and existing is None:
                        for index,rune in enumerate(values):
                            if rune:
                                self.store._db.execute("INSERT INTO equipped_runes VALUES(?,?,?,?,?)",
                                    (device,index//30+1,index%30,rune,int(time.time())))
                    self.store._db.execute("UPDATE account_restore_state SET runes_migrated=1 WHERE uid=?", (a.uid,))
                pages=[self.store.rune_page_snapshot(device,p) for p in (1,2)]
                return build_p7_rune_inventory(pages=pages)
            m=parse_rune_mutation(pid,payload)
            if m.rune_id and m.rune_id not in OWNED: raise ValueError("unknown rune")
            self.store._db.execute("UPDATE account_restore_state SET runes_migrated=1 WHERE uid=?", (a.uid,))
            if pid==40:
                self.store._db.execute("DELETE FROM equipped_runes WHERE device_id=? AND rune_page=?", (device,m.page+1))
            elif pid==39 or not m.rune_id:
                self.store._db.execute("DELETE FROM equipped_runes WHERE device_id=? AND rune_page=? AND slot=?", (device,m.page+1,m.slot))
            else:
                self.store._db.execute("""INSERT INTO equipped_runes VALUES(?,?,?,?,?)
                    ON CONFLICT(device_id,rune_page,slot) DO UPDATE SET rune_id=excluded.rune_id,updated_at=excluded.updated_at""",
                    (device,m.page+1,m.slot,m.rune_id,int(time.time())))
            return build_rune_page_response(m.page,self.store.rune_page_snapshot(device,m.page+1))

    def member(self, row, online=False):
        # Community IBHMLPMENFJ: uint id, string name, level, tier, icon.
        return struct.pack("<I",row["device_id"])+core.encode_text(row["nickname"])+bytes((row["level"],0,0))

    def friend_list(self, device):
        a=self.account(device)
        with self.store._lock:
            pending=self.store._db.execute("""SELECT a.* FROM account_friends f JOIN accounts a ON a.uid=f.requester
                WHERE f.recipient=? AND f.accepted=0 ORDER BY a.uid LIMIT 50""",(a.uid,)).fetchall()
            friends=self.store._db.execute("""SELECT a.* FROM account_friends f JOIN accounts a
                ON a.uid=CASE WHEN f.requester=? THEN f.recipient ELSE f.requester END
                WHERE (f.requester=? OR f.recipient=?) AND f.accepted=1 ORDER BY a.uid LIMIT 50""",(a.uid,a.uid,a.uid)).fetchall()
        result=bytearray()
        for rows in (pending,friends):
            result+=struct.pack("<H",len(rows))
            for row in rows:
                seen=self.presence.get(row["device_id"],0)
                result+=self.member(row)+struct.pack("<qB",int(max(0,seen)*10000000)+TICKS_EPOCH,self.presence_state.get(row["device_id"],1) if time.time()-seen<45 else 0)
        return bytes(result)

    def community(self, device, pid, payload):
        a=self.account(device)
        with self.lock:
            if pid==2:
                self.presence.pop(device,None)
                self.presence_state.pop(device,None)
                return b"\0"
            self.presence[device]=time.time()
            if pid==1:
                if len(payload)!=16 or struct.unpack_from("<i",payload)[0]!=13 or struct.unpack_from("<I",payload,4)[0]!=device:
                    return b"\x02"
                row={"device_id":device,"nickname":a.nickname,"level":a.level}
                return b"\0"+self.member(row)+struct.pack("<IIqiIBII",a.exp,0,a.gold,0,0,0,0,0)+b"\0"
            if pid==3: return b"\0"+struct.pack("<i",0)
            if pid==4: return self.friend_list(device)
            if pid==5:
                if len(payload)!=1: raise ValueError("presence payload")
                if payload[0] not in (0,1,2):raise ValueError("invalid presence state")
                self.presence_state[device]=payload[0]
                return b""
            if pid==6:
                if len(payload)==15:
                    with self.state.lock:
                        battle=next((p for p in self.state.peers.values() if p.device_id==device and p.room_id and p.peer_id in self.state.managed_battle.contexts),None)
                        if battle is None:return bytes((16,payload[14]))
                        context=self.state.managed_battle.contexts[battle.peer_id]
                        payload=payload[:10]+struct.pack("<I",battle.room_id)+payload[14:15]+bytes((context["mode"],))+struct.pack("<I",context["group"])
                if len(payload)!=20:raise ValueError("invite context")
                target=struct.unpack_from("<I",payload)[0]
                native_room=struct.unpack_from("<I",payload,10)[0];team=payload[14];mode=payload[15]
                native_group=struct.unpack_from("<I",payload,16)[0]
                if team>1 or not native_room or not self.are_friends(device,target):return bytes((3,team))
                if time.time()-self.presence.get(target,0)>=45 or self.presence_state.get(target,1)!=1:return bytes((41,team))
                with self.state.lock:
                    peer=next((p for p in self.state.peers.values() if p.device_id==device and p.room_id),None)
                    room=self.state.rooms.get(peer.room_id) if peer else None
                    if room is None or len(room.members)>=room.capacity:return bytes((16,team))
                    token=bytes((127,))+secrets.token_bytes(3)+struct.pack("<H",20002)
                    self.invites[(target,token)]=(room.room_id,mode,native_group,time.time()+60)
                queue=self.events.setdefault(target,[])
                if len(queue)>=32:return bytes((16,team))
                queue.append((7,struct.pack("<I",device)+core.encode_text(a.nickname)+struct.pack("<IB",native_room,team)+token))
                return bytes((0,team))
            if pid==13:
                if len(payload)<6:raise ValueError("chat payload")
                target=struct.unpack_from("<I",payload)[0]
                text,end=core.decode_text(payload,4)
                if end!=len(payload) or not text.strip() or len(text)>500:raise ValueError("invalid chat")
                if not self.are_friends(device,target):return bytes((41,))+struct.pack("<I",target)
                if time.time()-self.presence.get(target,0)>=45:return bytes((41,))+struct.pack("<I",target)
                message=core.encode_text(text)
                queue=self.events.setdefault(target,[])
                if len(queue)>=32:return bytes((41,))+struct.pack("<I",target)
                queue.append((13,b"\0"+struct.pack("<II",device,device)+message))
                return b"\0"+struct.pack("<II",target,device)+message
            if pid==8:
                name,end=core.decode_text(payload)
                if end!=len(payload): raise ValueError("friend request payload")
                with self.store._lock,self.store._db:
                    target=self.store._db.execute("SELECT * FROM accounts WHERE nickname=?",(name,)).fetchone()
                    if target is None or target["uid"]==a.uid: return b"\x03"
                    other=target["uid"]
                    pair=self.store._db.execute("""SELECT accepted FROM account_friends
                        WHERE (requester=? AND recipient=?) OR (requester=? AND recipient=?)""",(a.uid,other,other,a.uid)).fetchone()
                    if pair is not None: return bytes((35 if pair[0] else 34,))
                    for uid in (a.uid,other):
                        count=self.store._db.execute("SELECT count(*) FROM account_friends WHERE requester=? OR recipient=?",(uid,uid)).fetchone()[0]
                        if count>=50:return b"\x10"
                    self.store._db.execute("INSERT INTO account_friends VALUES(?,?,0)",(a.uid,other))
                return b"\0"
            if pid in (9,10,11,12):
                if len(payload)!=4: raise ValueError("friend id payload")
                target_device=struct.unpack("<I",payload)[0]
                with self.store._lock,self.store._db:
                    row=self.store._db.execute("SELECT uid FROM accounts WHERE device_id=?",(target_device,)).fetchone()
                    if row is None:return b"\x03"
                    other=row[0]
                    if pid==9:
                        cur=self.store._db.execute("UPDATE account_friends SET accepted=1 WHERE requester=? AND recipient=? AND accepted=0",(other,a.uid))
                        if cur.rowcount!=1:return b"\x03"
                    elif pid==10:
                        self.store._db.execute("DELETE FROM account_friends WHERE requester=? AND recipient=? AND accepted=0",(other,a.uid))
                    elif pid==11:
                        self.store._db.execute("""DELETE FROM account_friends WHERE
                            (requester=? AND recipient=?) OR (requester=? AND recipient=?)""",(a.uid,other,other,a.uid))
                    else:
                        target=self.store._db.execute("SELECT * FROM accounts WHERE uid=?",(other,)).fetchone()
                        seen=self.presence.get(target_device,target["updated_at"])
                        return b"\0"+core.encode_text(target["nickname"])+struct.pack("<IBIIq",0,0,0,0,int(seen*10000000)+TICKS_EPOCH)
                return b"\0"+self.friend_list(device)
            return b"\x2a"

    def prepare_invite(self,device,payload):
        if len(payload)!=16 or payload[1]!=2:raise ValueError("invite join request")
        with self.lock:
            invitation=self.invites.get((device,payload[-6:]))
            if invitation is None or invitation[3]<time.time():return b"\x01"
            room_id,mode,group,expires=invitation
            with self.state.lock:
                room=self.state.rooms.get(room_id)
                if room is None or len(room.members)>=room.capacity:return b"\x01"
            self.pending_joins[device]=invitation
            return b"\0"+struct.pack("<BI",mode,group)

    def are_friends(self,device,target):
        with self.store._lock:
            rows=self.store._db.execute("""SELECT f.accepted FROM account_friends f
                JOIN accounts a ON a.uid=f.requester JOIN accounts b ON b.uid=f.recipient
                WHERE f.accepted=1 AND ((a.device_id=? AND b.device_id=?) OR (a.device_id=? AND b.device_id=?))""",
                (device,target,target,device)).fetchone()
            return rows is not None

    def dispatch(self, device, service, pid, payload):
        if service==2 and pid==0 and not payload:
            with self.lock:
                waiting=self.events.get(device,[]);queued=[];total=2
                while waiting and total+4+len(waiting[0][1])<=7000:
                    item=waiting.pop(0);queued.append(item);total+=4+len(item[1])
                if not waiting:self.events.pop(device,None)
                return struct.pack("<H",len(queued))+b"".join(struct.pack("<HH",p,len(body))+body for p,body in queued)

        if service==0:
            if pid==33:return self.results.leaderboard(payload)
            if pid==27:return self.results.result(device,payload)
            if pid==25:return self.state.managed_battle.prepare(device,payload)
            if pid==4:return self.profile(device)
            if pid==17:return self.nickname(device,payload)
            if pid in (7,38,39,40):return self.runes(device,pid,payload)
        if service==1:return self.community(device,pid,payload)
        raise ValueError("unsupported account request")
