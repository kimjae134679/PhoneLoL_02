"""Focused disposable-server checks for the managed lobby/battle protocol."""
import sys, socket, struct, tempfile, threading, pathlib, contextlib
ROOT=pathlib.Path(__file__).resolve().parent
sys.path.insert(0,str(ROOT))
sys.path.append(r"C:\Users\user\Documents\MultiGod\PhoneLOL_LocalRuntime\recovery\01_server_v0965_snapshot\APK")
import server_central_authority_v33 as server
import server_v4 as core
import server_v4_original_adapter as original
import managed_battle_v1167 as battle
def exact(s,n):
    data=b""
    while len(data)<n:
        part=s.recv(n-len(data))
        if not part: raise EOFError()
        data+=part
    return data
class Client:
    def __init__(self,port,device):
        self.s=socket.create_connection(("127.0.0.1",port),timeout=5)
        self.device=device;self.peer=0
        self.send(1,struct.pack("<III",4,core.FRIEND,device))
        self.peer,self.session,_=struct.unpack("<IIQ",self.receive(2))
        self.account=self.receive(21)
        self.token=struct.unpack_from("<q",self.account,5)[0]
    def send(self,kind,data):
        self.s.sendall(core.pack(kind,data,0,self.peer))
    def receive(self,kind,pid=None):
        for _ in range(100):
            header=exact(self.s,16);size,k,*_=core.HEADER.unpack(header)
            data=exact(self.s,size-16)
            if k==kind and (pid is None or struct.unpack_from("<H",data)[0]==pid):
                return data if pid is None else data[6:]
        raise AssertionError("Expected response not received")
    def rpc(self,service,pid,data):
        self.send(64,struct.pack("<BH",service,pid)+data)
        reply=self.receive(65)
        assert reply[:3]==struct.pack("<BH",service,pid)
        return reply[3:]
    def legacy(self,pid,data=b""): self.send(66,struct.pack("<Hi",pid,0)+data)
def run():
    with tempfile.TemporaryDirectory(prefix="phonelol-v1167-") as tmp:
        srv=server.build_server("127.0.0.1",0,str(pathlib.Path(tmp)/"test.db"))
        thread=threading.Thread(target=srv.serve_forever,daemon=True);thread.start()
        clients=[]
        try:
            a=Client(srv.server_address[1],991700001);b=Client(srv.server_address[1],991700002)
            clients.extend((a,b))
            before=srv.state.accounts.get_or_create(a.device).gold
            for name in ("SmokeAlpha","SmokeBeta","SmokeAlpha"):
                reply=a.rpc(0,17,core.encode_text(name))
                assert reply[0]==0
                _,end=core.decode_text(reply,1)
                assert struct.unpack_from("<q",reply,end)[0]==before
            print("PASS: repeated nickname changes preserve balance without cooldown")
            for c in clients:
                prep=c.rpc(0,25,bytes((20,0))+bytes(14));assert len(prep)==17 and prep[0]==0
                c.legacy(1,struct.pack("<iIq",79,c.device,c.token))
                assert c.receive(67,1)[0]==0
                c.legacy(4,bytes((20,0)))
                enter=c.receive(67,7);assert enter[0]==0
            peers=[srv.state.peers[c.peer] for c in clients]
            assert peers[0].room_id==peers[1].room_id
            room=srv.state.rooms[peers[0].room_id]
            roster=srv.state.managed_battle.player(peers[0])+srv.state.managed_battle.roster(room)
            (ROOT.parent.parent/".git/managed-room-probe.bin").write_bytes(roster)
            print("PASS: two authenticated clients join the same real room")
            hero=min(original.BASE_HERO_IDS)
            for c in clients:
                c.legacy(12,struct.pack("<H",hero))
                c.receive(67,24)
            for c in clients: c.legacy(16)
            for c in clients:
                start = c.receive(67,18)
                assert start[0] == 1
                for p in peers:
                    _,_,view_id,session = struct.unpack_from("<HBii", start, 1 + p.visual.slot * 11)
                    assert view_id == (session+1)*1000+1 and view_id >= 1000
            print("PASS: champion view IDs cannot collide with scene objects")
            print("PASS: real player selection and shared countdown")
            for c in clients: c.legacy(19,struct.pack("<i",100))
            starts=[c.receive(67,20) for c in clients]
            assert starts[0]==starts[1] and starts[0][0]==1
            a.legacy(60019,struct.pack("<iH",-1,60016)+b"managed-relay-probe")
            assert b.receive(67,60016)==b"managed-relay-probe"
            a.legacy(60019,struct.pack("<iH",srv.state.managed_battle.session(peers[1]),60016)+b"directed-probe")
            assert b.receive(67,60016)==b"directed-probe"
            print("PASS: both loading acknowledgements and shared battle packet relay")
            for c in clients:
                c.legacy(21)
                c.legacy(3)
                assert c.receive(67,3)==b"\0"
            def outcome(room, active):
                by_slot={p.visual.slot:p for p in active}
                data=bytearray(struct.pack("<Bii",0,3,1))
                for slot in range(room.capacity):
                    p=by_slot.get(slot)
                    data+=bytes((p is not None,))
                    if p:
                        account=srv.state.accounts.get_or_create(p.device_id)
                        data+=struct.pack("<IH",p.device_id,p.visual.hero_id)+core.encode_text(account.nickname)
                        items = [1001] * (8 if room.mode == 10 else 5)
                        data+=struct.pack("<IBHHHHB"+str(len(items))+"H",0,5,3 if slot%2==0 else 1,1,0,4,0,*items)
                return bytes(data)
            body=outcome(room,peers)
            host=next(c for c in clients if c.peer==room.host_peer)
            nonhost=next(c for c in clients if c is not host)
            nonhost.legacy(22,body);assert nonhost.receive(67,22)==b"\xff"
            host.legacy(22,body)
            for c in clients:assert c.receive(67,22)==body
            board=a.rpc(0,33,b"\x01")
            assert struct.unpack_from("<H",board)[0]==2
            stats_before=[srv.state.account_services.results.stats(srv.state.accounts.get_or_create(c.device).uid) for c in clients]
            assert sorted(x[1][0] for x in stats_before)==[984,1016]
            host.legacy(22,body)
            for c in clients:assert c.receive(67,22)==body
            stats_after=[srv.state.account_services.results.stats(srv.state.accounts.get_or_create(c.device).uid) for c in clients]
            assert stats_after==stats_before
            reply=a.rpc(0,27,struct.pack("<QH?ii",room.shared_game_id,hero,True,0,0))
            assert len(reply)==85
            assert srv.state.accounts.get_or_create(a.device).gold==before
            print("PASS: authenticated results, persistent ranking, idempotent settlement and exact 85-byte result")
            solo=Client(srv.server_address[1],991700003);clients.append(solo)
            assert solo.rpc(0,25,bytes((10,0))+bytes(14))[0]==0
            solo.legacy(1,struct.pack("<iIq",79,solo.device,solo.token));assert solo.receive(67,1)[0]==0
            solo.legacy(4,bytes((10,0)));assert solo.receive(67,7)[0]==0
            solo.legacy(61001,b"\x01");solo.legacy(3);assert solo.receive(67,3)==b"\0"
            assert srv.state.peers[solo.peer].visual.slot == 1
            solo.legacy(61001,b"\x00");solo.legacy(3);assert solo.receive(67,3)==b"\0"
            assert srv.state.peers[solo.peer].visual.slot == 0
            print("PASS: team movement in both directions preserves actual room membership")
            solo.legacy(12,struct.pack("<H",hero));solo.receive(67,24)
            solo.legacy(16);assert solo.receive(67,18)[0]==1
            solo.legacy(19,struct.pack("<i",100));assert solo.receive(67,20)[0]==1
            solo.legacy(21);solo.legacy(3);assert solo.receive(67,3)==b"\0"
            sp=srv.state.peers[solo.peer];sr=srv.state.rooms[sp.room_id]
            solo_body=outcome(sr,[sp]);solo.legacy(22,solo_body);assert solo.receive(67,22)==solo_body
            assert srv.state.account_services.results.stats(srv.state.accounts.get_or_create(solo.device).uid)[0]==(0,0,0,0,0)
            print("PASS: one real player starts, loads and completes without artificial opponents or ranking gains")
        finally:
            for c in clients: c.s.close()
            srv.shutdown();srv.server_close()
if __name__=="__main__":
    log=ROOT.parent.parent/".git/managed-server-check.log"
    try:
        with log.open("w",encoding="utf-8") as stream,contextlib.redirect_stdout(stream):
            run()
    except Exception:
        import traceback
        traceback.print_exc()
        raise
    print("Focused server checks passed; temporary database removed.")
