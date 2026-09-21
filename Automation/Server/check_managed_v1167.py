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
            for c in clients: assert c.receive(67,18)[0]==1
            print("PASS: real player selection and shared countdown")
            for c in clients: c.legacy(19,struct.pack("<i",100))
            starts=[c.receive(67,20) for c in clients]
            assert starts[0]==starts[1] and starts[0][0]==1
            a.legacy(60019,struct.pack("<iH",-1,60016)+b"managed-relay-probe")
            assert b.receive(67,60016)==b"managed-relay-probe"
            print("PASS: both loading acknowledgements and shared battle packet relay")
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
