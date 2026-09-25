"""Disposable integration checks for 1.7.0 rooms and nickname persistence."""
import contextlib, io, pathlib, struct, tempfile, threading, traceback
from check_managed_v1167 import Client, server, core, original

def run():
    with tempfile.TemporaryDirectory(prefix="phonelol-v170-") as tmp:
        db=str(pathlib.Path(tmp)/"test.db")
        srv=server.build_server("127.0.0.1",0,db)
        threading.Thread(target=srv.serve_forever,daemon=True).start()
        clients=[]
        device=991710000
        try:
            a=Client(srv.server_address[1],device);clients.append(a)
            name="유지170"
            for nick in ("First170",name):
                assert a.rpc(0,17,core.encode_text(nick))[0]==0
            assert srv.state.accounts.get_or_create(device).nickname==name
            a.s.close()
            a=Client(srv.server_address[1],device);clients.append(a)
            assert srv.state.accounts.get_or_create(device).nickname==name
            assert core.encode_text(name) in a.rpc(0,4,b"")
            print("PASS nickname change and reconnect profile")
            for mode,count in ((101,2),(102,10),(103,10)):
                group=[]
                for index in range(count):
                    c=Client(srv.server_address[1],device+mode*100+index);clients.append(c);group.append(c)
                    assert c.rpc(0,25,bytes((mode,1))+bytes(14))[0]==0
                    c.legacy(1,struct.pack("<iIq",79,c.device,c.token));assert c.receive(67,1)[0]==0
                    c.legacy(5 if index==0 else 4,bytes((mode,0)))
                    assert c.receive(67,7)[0]==0
                peers=[srv.state.peers[c.peer] for c in group]
                assert len({p.room_id for p in peers})==1
                room=srv.state.rooms[peers[0].room_id]
                assert room.capacity==count
                assert sorted(p.visual.slot for p in peers)==list(range(count))
                assert sum(p.visual.slot%2==0 for p in peers)==count//2
                roster=srv.state.managed_battle.player(peers[0])+srv.state.managed_battle.roster(room)
                (pathlib.Path(__file__).resolve().parents[2]/".git"/f"v170-room-{mode}.bin").write_bytes(roster)
                for c in group:
                    c.legacy(12,struct.pack("<H",min(original.BASE_HERO_IDS)));c.receive(67,24)
                for c in group:c.legacy(16)
                starts=[c.receive(67,18) for c in group]
                assert len(set(starts))==1 and len(starts[0])==1+11*max(6,count)
                assert len({struct.unpack_from("<HBii",starts[0],1+i*11)[2] for i in range(count)})==count
                for c in group:c.legacy(19,struct.pack("<i",100))
                loaded=[c.receive(67,20) for c in group];assert len(set(loaded))==1
                for c in group:c.legacy(21);c.legacy(3);assert c.receive(67,3)==b"\0"
                payload=bytearray(struct.pack("<Bii",0,0,0))
                for p in sorted(peers,key=lambda p:p.visual.slot):
                    acc=srv.state.accounts.get_or_create(p.device_id)
                    payload+=b"\1"+struct.pack("<IH",p.device_id,p.visual.hero_id)+core.encode_text(acc.nickname)
                    items=8 if mode==103 else 5
                    payload+=struct.pack("<IBHHHHB"+str(items)+"H",0,1,0,0,0,0,0,*([0]*items))
                host=next(c for c in group if c.peer==room.host_peer)
                host.legacy(22,bytes(payload))
                for c in group:assert c.receive(67,22)==payload
                print(f"PASS mode={mode} capacity={count}, balanced teams, roster/start/load/results, items={items}")
        finally:
            for c in clients:c.s.close()
            srv.shutdown();srv.server_close()
        srv=server.build_server("127.0.0.1",0,db)
        threading.Thread(target=srv.serve_forever,daemon=True).start()
        try:
            a=Client(srv.server_address[1],device)
            try:
                assert srv.state.accounts.get_or_create(device).nickname==name
                assert core.encode_text(name) in a.rpc(0,4,b"")
                print("PASS nickname persists after server restart with same database")
            finally:a.s.close()
        finally:srv.shutdown();srv.server_close()
if __name__=="__main__":
    report=pathlib.Path(__file__).resolve().parents[2]/"Recovery/V170ServerVerification.txt"
    capture=io.StringIO()
    try:
        with contextlib.redirect_stdout(capture):run()
    except Exception:
        report.write_text(capture.getvalue()+traceback.format_exc(),encoding="utf-8")
        raise
    report.write_text("\n".join(x for x in capture.getvalue().splitlines() if x.startswith("PASS"))+"\n",encoding="utf-8")
    print("1.7.0 integration checks passed.")
