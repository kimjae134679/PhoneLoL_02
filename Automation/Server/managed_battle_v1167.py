"""Managed legacy battle transport for the recovered ARM64 client."""
import json
import struct
import time
import threading
from pathlib import Path
import server_v4 as core
import server_v093 as legacy

REQUEST, RESPONSE = 66, 67
ENVELOPE = struct.Struct("<Hi")
ENDPOINT = bytes((127, 0, 0, 1)) + struct.pack("<H", 20002)

class ManagedBattle:
    def __init__(self, state, raw_send):
        self.state, self.raw_send = state, raw_send
        self.contexts, self.prepared, self.loaded = {}, {}, {}
        self.started_at, self.result_frames = {}, {}
        self.lock = threading.RLock()
        self.catalog = json.loads(Path(__file__).with_name("managed_rune_catalog.json").read_text())
    def send(self, peer, pid, body=b"", request=0):
        return self.raw_send(peer, RESPONSE, ENVELOPE.pack(pid, request)+body, peer.room_id, peer.peer_id)
    def prepare(self, device, payload):
        if len(payload) != 16:
            return b"\x01"
        mode, operation = payload[0], payload[1]
        if mode not in (0, 10, 20, 101, 102) or operation not in (0, 1, 2, 3):
            return b"\x01"
        target = 0
        if operation == 2:
            response = self.state.account_services.prepare_invite(device, payload)
            if not response or response[0]:
                return b"\x01"
            mode, group = struct.unpack_from("<BI", response, 1)
            invitation = self.state.account_services.pending_joins.get(device)
            if invitation: target = invitation[0]
        else:
            group = 0x11670000 + (1 if mode == 10 or operation in (1, 3) else 0)
        with self.lock:
            self.prepared[device] = (mode, operation, group, target, time.monotonic()+120)
        return b"\0"+bytes((mode, operation))+struct.pack("<ii",mode,group)+ENDPOINT
    def context(self, peer):
        return self.contexts[peer.peer_id]
    def player(self, peer):
        a = self.state.accounts.get_or_create(peer.device_id)
        v = peer.visual
        ctx = self.contexts.get(peer.peer_id, {})
        return (struct.pack("<I",peer.device_id)+core.encode_text(a.nickname)+bytes((a.level,))+
                struct.pack("<iBHBBBBIBI",peer.session_key,v.slot%2,v.hero_id,v.skin_id,
                            v.slot,v.ready,ctx.get("lane",v.lane_role),0,ctx.get("page",0),0))
    def rune(self, peer):
        totals = [0.0]*28
        if peer is not None:
            page = self.contexts.get(peer.peer_id,{}).get("page",0)+1
            for rune in self.state.accounts.rune_page_snapshot(peer.device_id,page):
                if not rune: continue
                values = self.catalog[str(rune)]
                totals = [struct.unpack("<f",struct.pack("<f",a+b))[0] for a,b in zip(totals,values)]
        raw = struct.pack("<28f",*totals)
        checksum = 0
        for value in struct.unpack("<28I",raw): checksum ^= value
        # The original aggregate rune has no item name or price.
        return struct.pack("<HBBHB",0,0,0,0,1)+raw+struct.pack("<i",0), checksum
    def members(self, room):
        return [self.state.peers[x] for x in room.members if x in self.state.peers]
    def roster(self, room):
        peers = {p.visual.slot:p for p in self.members(room)}
        host = self.state.peers.get(room.host_peer)
        host_slot = host.visual.slot if host else 0
        started = room.room_id in self.state.authoritative_started_rooms
        mode = self.contexts.get(room.host_peer,{}).get("mode",room.mode)
        out = bytearray(struct.pack("<iBBBQBB",room.room_id,2 if started else 1,
                                    room.capacity,host_slot,room.shared_game_id,1,mode))
        for slot in range(6):
            p = peers.get(slot)
            out += bytes((p is not None,))
            if p: out += self.player(p)
            a = self.state.accounts.get_or_create(p.device_id) if p else None
            out += struct.pack("<I",p.device_id if p else 0)+core.encode_text(a.nickname if a else "")
            out += struct.pack("<BiB",a.level if a else 0,0,0)
            rune, checksum = self.rune(p)
            out += rune+struct.pack("<IHBiII",checksum,p.visual.hero_id if p else 0,
                     p.visual.skin_id if p else 0,slot+1 if p else 0,
                     p.session_key if p else 0,0)
        return bytes(out)
    def publish(self, peer, force=False):
        with self.state.lock, self.lock:
            ctx = self.contexts.get(peer.peer_id)
            room = self.state.rooms.get(peer.room_id)
            if not ctx or not room or ctx.get("started"): return
            roster = self.roster(room)
            body = self.player(peer)+roster
            if not force and body == ctx.get("last"): return
            ctx["last"] = body
            self.send(peer,24,body)
            if not ctx.get("joined"):
                ctx["joined"] = True
                self.send(peer,7,bytes((0,peer.visual.slot%2,ctx.get("lane",0)))+roster)
    def publish_room(self, room_id):
        with self.state.lock:
            room = self.state.rooms.get(room_id)
            peers = self.members(room) if room else []
        for p in peers: self.publish(p)
    def central_event(self, peer, kind, payload, room_id, source):
        if peer.peer_id not in self.contexts: return False
        if kind == core.ROOM_SNAPSHOT: self.publish(peer)
        elif kind == core.PLAYER_STATE: self.publish_room(peer.room_id)
        elif kind == legacy.MATCH_FAIL: self.send(peer,7,b"\x01")
        elif kind == core.START_SYNC: self.start(peer)
        return kind in (core.MATCH_OK, legacy.MATCH_FAIL, core.ROOM_SNAPSHOT,
                        core.PLAYER_STATE, core.STATE_ACK, core.START_SYNC,core.PEER_JOIN,core.PEER_LEAVE)
    def start(self, peer):
        with self.state.lock, self.lock:
            ctx = self.contexts.get(peer.peer_id); room = self.state.rooms.get(peer.room_id)
            if not ctx or not room or ctx.get("started"): return
            self.publish(peer,True)
            ctx["started"] = True
            self.started_at.setdefault(room.room_id,time.monotonic())
            members = self.members(room)
            host = self.state.peers[room.host_peer].session_key
            # Register self first so Eve creates the group before adding its other members.
            for p in [peer]+[x for x in members if x.peer_id != peer.peer_id]:
                self.send(peer,60004,struct.pack("<iii",room.room_id,p.session_key,host)+ENDPOINT+ENDPOINT)
            by_slot = {p.visual.slot:p for p in members}
            data = bytearray(b"\x01")
            for slot in range(6):
                p = by_slot.get(slot)
                data += struct.pack("<HBii",p.visual.hero_id if p else 0,
                                    p.visual.skin_id if p else 0,slot+1 if p else 0,
                                    p.session_key if p else 0)
            self.send(peer,18,bytes(data))
    def maybe_start_ready(self, peer):
        # Managed rooms allow solo play while retaining authenticated readiness.
        with self.state.lock, self.lock:
            room = self.state.rooms.get(peer.room_id)
            if not room or room.room_id in self.state.authoritative_started_rooms:
                return False
            members = self.members(room)
            if not members or room.host_peer not in {p.peer_id for p in members}:
                return False
            if any(p.peer_id not in self.contexts or p.visual.ready != 1 or
                   p.visual.hero_id not in range(1,28) for p in members):
                return False
            self.state.starting_rooms.add(room.room_id)
            self.state.authoritative_started_rooms.add(room.room_id)
            payload = core.START.pack(room.epoch,room.shared_game_id)
            for target in members:
                self.state.send(target,core.START_SYNC,payload,room.room_id,0)
            return True

    def handle(self, peer, envelope):
        if len(envelope)<6 or len(envelope)>60000: raise ValueError("Invalid managed battle envelope")
        pid, request = ENVELOPE.unpack_from(envelope); data = envelope[6:]
        if pid == 1:
            if len(data)<16: raise ValueError("Truncated battle authentication")
            version, device, token = struct.unpack_from("<iIq",data)
            account = self.state.accounts.get_or_create(peer.device_id)
            if version!=79 or device!=peer.device_id or token!=account.auth_token:
                return self.send(peer,1,b"\x02",request)
            with self.lock:
                prepared = self.prepared.pop(device,None)
                if not prepared or prepared[4]<time.monotonic():
                    return self.send(peer,1,b"\xff",request)
                mode, operation, group, target, expires = prepared
                self.contexts[peer.peer_id] = dict(mode=mode,operation=operation,group=group,
                                                  target=target,lane=0,page=0)
            return self.send(peer,1,b"\0"+self.player(peer)+struct.pack("<i",-1),request)
        ctx = self.context(peer)
        if pid == 3: return self.send(peer,3,b"\0",request)
        if pid in (4,5,8):
            mode = ctx["mode"]
            capacity = {20:2,101:2,102:4}.get(mode,6)
            operation = legacy.MATCH_OP_CREATE if pid==5 else legacy.MATCH_OP_FIND_OR_CREATE
            target = ctx["target"]
            if pid==8:
                if len(data)!=5: raise ValueError("Invalid room join")
                target = struct.unpack_from("<I",data)[0]; operation=legacy.MATCH_OP_JOIN
            if target: operation=legacy.MATCH_OP_JOIN
            self.state.match_operation(peer,core.FRIEND,ctx["group"],mode,capacity,operation,target,request)
            self.publish(peer,True)
            return
        if pid==10:
            room_id=peer.room_id
            self.send(peer,10,b"\0"+struct.pack("<I?",peer.device_id,False),request)
            self.state._leave_current_room_for_rematch(peer)
            ctx.update(joined=False,started=False,last=None)
            self.publish_room(room_id)
            return
        with self.state.lock: room = self.state.rooms.get(peer.room_id)
        if room is None: return self.send(peer,7,b"\x01",request)
        v=peer.visual
        if pid in (12,13,14,16):
            hero,skin,lane,ready = v.hero_id,v.skin_id,v.lane_role,v.ready
            if pid==12:
                if len(data)!=2: raise ValueError("Invalid champion pick")
                hero=struct.unpack("<H",data)[0];skin=0
            elif pid==13:
                if len(data)!=1: raise ValueError("Invalid skin pick")
                skin=data[0]
            elif pid==14:
                if len(data)!=1 or data[0]>3: raise ValueError("Invalid lane")
                lane=data[0]
            else: ready=0 if ready else 1
            self.state.update_player_state(peer,core.PSTATE.pack(v.slot,lane,ready,skin,hero,0))
            ctx["lane"]=peer.visual.lane_role
            self.publish_room(peer.room_id)
            self.maybe_start_ready(peer)
            return
        if pid==15:
            if len(data)!=1 or data[0]>1: raise ValueError("Invalid rune page")
            if ctx.get("started"): return
            ctx["page"]=data[0];self.publish_room(peer.room_id);return
        if pid==19:
            if len(data)!=4 or not ctx.get("started"): raise ValueError("Invalid loading completion")
            with self.lock:
                loaded=self.loaded.setdefault(room.room_id,set());loaded.add(peer.peer_id)
                members=self.members(room)
                for target in members: self.send(target,19,struct.pack("<I",peer.device_id)+data)
                if all(x.peer_id in loaded for x in members):
                    for target in members: self.send(target,20,struct.pack("<?Q",True,room.shared_game_id))
            return
        if pid==21:
            if data or not ctx.get("started"):
                raise ValueError("Invalid world initialization marker")
            ctx["world_initialized"] = True
            print("MANAGED_WORLD_READY room="+str(room.room_id)+" peer="+str(peer.peer_id),flush=True)
            return
        if pid==22:
            if not ctx.get("started") or peer.peer_id != room.host_peer:
                raise ValueError("Only the active room host can submit its result")
            with self.state.lock, self.lock:
                members = self.members(room)
                if not all(self.contexts.get(p.peer_id,{}).get("world_initialized") for p in members):
                    raise ValueError("Result arrived before world initialization")
                competitive = room.mode in (0,20) and room.group == 0x11670000 and len(members)>1
                body = self.state.account_services.results.settle(
                    room,members,data,time.monotonic()-self.started_at[room.room_id],competitive)
                self.result_frames[room.room_id] = body
                for target in members:
                    self.send(target,22,body,request if target is peer else 0)
            return
        if pid==60019:
            if len(data)<6 or not ctx.get("started"): raise ValueError("Invalid battle relay")
            target_session, original_pid = struct.unpack_from("<iH",data)
            if not 60014<=original_pid<=60018: raise ValueError("Invalid original battle packet")
            for target in self.members(room):
                if target_session==-2 or (target_session==-1 and target!=peer) or target.session_key==target_session:
                    if target.peer_id in self.contexts: self.send(target,original_pid,data[6:])
            return
        if pid==6:
            return self.send(peer,6,b"\x01")
        # Unsupported requests fail explicitly without inventing a match or account reward.
        print("MANAGED_BATTLE_UNSUPPORTED pid="+str(pid),flush=True)
        return self.send(peer,pid,b"\xff",request)
    def disconnected(self, peer):
        room_id=peer.room_id
        with self.lock:
            self.contexts.pop(peer.peer_id,None)
            for loaded in self.loaded.values(): loaded.discard(peer.peer_id)
        return room_id
