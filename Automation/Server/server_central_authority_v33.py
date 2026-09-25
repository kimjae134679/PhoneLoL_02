"""V3.3: original device-account and community services on the V3.2 transport."""
from __future__ import annotations
import os,time,struct
import server_v093 as legacy
import server_v4 as core
import server_central_authority_v32 as v32
import server_central_authority_v30 as transport
from account_services_v1158 import AccountServices, RPC_GET, RPC_RESULT, RPC_HEADER
from managed_battle_v1167 import ManagedBattle, REQUEST, RESPONSE
# Managed battle frames have the same high-frequency role as native battle data.
# Retain connection/rejection/overflow diagnostics, without flushing a log per frame.
transport.QUIET_RX_KINDS = transport.QUIET_RX_KINDS | {REQUEST}
transport.QUIET_TX_KINDS = transport.QUIET_TX_KINDS | {RESPONSE}
SERVER_VERSION="central-authority-v3.3-persistent-original-accounts"
class CentralAuthorityV33State(v32.CentralAuthorityV32State):
    def __init__(self,db_path):
        super().__init__(db_path)
        self.account_services=AccountServices(self)
        self.managed_battle=ManagedBattle(self,super().send)
    def send(self,peer,kind,payload=b"",room=0,source_peer=0):
        bridge=getattr(self,"managed_battle",None)
        if bridge and bridge.central_event(peer,kind,payload,room,source_peer):
            return True
        return super().send(peer,kind,payload,room,source_peer)
    def _writer_failure(self,peer,reason):
        super()._writer_failure(peer,reason)
        # Windows may leave the reader blocked after shutdown from the writer.
        # Detach immediately so an overflowing/dead receiver is not shown online.
        self.disconnect(peer)
    def disconnect(self,peer):
        with self.lock:
            # Writer failure and reader finally may race; notify/migrate once.
            if self.peers.get(peer.peer_id) is not peer:
                return
            bridge=getattr(self,"managed_battle",None)
            room=bridge.disconnected(peer) if bridge else 0
            super().disconnect(peer)
            if bridge: bridge.publish_room(room)
    def match(self,peer,friend,group,mode,capacity):
        capacity={20:2,101:2,102:10,103:10}.get(mode,capacity)
        with self.account_services.lock:
            invitation=self.account_services.pending_joins.get(peer.device_id)
        if invitation is not None:
            room_id,native_mode,native_group,expires=invitation
            with self.lock:room=self.rooms.get(room_id)
            expected_mode=native_mode if native_mode in (10,20,101,102,103) else 0
            if expires>=time.time() and expected_mode==mode and room is not None:
                result=super().match_operation(peer,room.friend,room.group,room.mode,room.capacity,legacy.MATCH_OP_JOIN,room_id,0)
                if peer.room_id==room_id:
                    with self.account_services.lock:self.account_services.pending_joins.pop(peer.device_id,None)
                return result
            with self.account_services.lock:self.account_services.pending_joins.pop(peer.device_id,None)
            self._send_match_failure(peer,legacy.MATCH_FAIL_BAD_REQUEST,0)
            return None
        return super().match(peer,friend,group,mode,capacity)
    def match_operation(self,peer,friend,group,mode,capacity,operation,target_room_id,request_id):
        capacity={20:2,101:2,102:10,103:10}.get(mode,capacity)
        return super().match_operation(peer,friend,group,mode,capacity,operation,target_room_id,request_id)
class CentralAuthorityV33Handler(v32.CentralAuthorityV32Handler):
    def _dispatch(self,kind,room,header_peer,payload):
        if kind==REQUEST:
            try:
                self.state.managed_battle.handle(self.peer,payload)
            except (ValueError,KeyError,IndexError,struct.error) as error:
                print("MANAGED_BATTLE_REJECTED "+type(error).__name__+": "+str(error),flush=True)
                if len(payload)>=6:
                    pid,request=struct.unpack_from("<Hi",payload)
                    self.state.managed_battle.send(self.peer,pid,b"\xff",request)
            return
        if kind==RPC_GET:
            if len(payload)<3 or len(payload)>4096:return
            service,pid=RPC_HEADER.unpack_from(payload)
            try:
                response=self.state.account_services.dispatch(self.peer.device_id,service,pid,payload[3:])
            except (ValueError,UnicodeError):
                response=b"\xff"
            self.state.send(self.peer,RPC_RESULT,RPC_HEADER.pack(service,pid)+response,0,self.peer.peer_id)
            return
        super()._dispatch(kind,room,header_peer,payload)
def build_server(host,port,db_path):
    return core.ThreadedServer((host,port),CentralAuthorityV33Handler,CentralAuthorityV33State(db_path))
def main():
    server=build_server(os.environ.get("HOST","0.0.0.0"),int(os.environ.get("PORT","29000")),os.environ.get("MULTIGOD_DB_PATH","multigod-central-authority-v3.db"))
    print("PhoneLOL "+SERVER_VERSION+" originalAccountRpc=64/65 battleBase="+v32.SERVER_VERSION,flush=True)
    try:server.serve_forever(poll_interval=0.25)
    finally:server.server_close()
if __name__=="__main__":main()
