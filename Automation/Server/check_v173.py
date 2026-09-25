"""Verify mode isolation and capture real multiplayer packets in a disposable server."""
import contextlib, io, pathlib, struct, tempfile, threading, traceback
from check_managed_v1167 import Client, server, core, exact
ROOT=pathlib.Path(__file__).resolve().parents[2]
def run():
 fixtures=ROOT/".git/v173-fixtures";fixtures.mkdir(exist_ok=True)
 with tempfile.TemporaryDirectory(prefix="phonelol-v173-") as tmp:
  srv=server.build_server("127.0.0.1",0,str(pathlib.Path(tmp)/"test.db"))
  threading.Thread(target=srv.serve_forever,daemon=True).start()
  clients=[];rooms=set()
  try:
   for case,(mode,operation) in enumerate([(0,0),(0,1),(10,0),(20,0),(101,3),(102,3),(103,3)]):
    group=[]
    for i in range(2):
     c=Client(srv.server_address[1],991730000+case*10+i);clients.append(c);group.append(c)
     assert c.rpc(0,25,bytes((mode,operation))+bytes(14))[0]==0
     c.legacy(1,struct.pack("<iIq",79,c.device,c.token))
     auth=c.receive(67,1);assert auth[0]==0
     (fixtures/f"{case}-{i}-auth.bin").write_bytes(auth)
     c.legacy(4,bytes((mode,0)));assert c.receive(67,7)[0]==0
    peers=[srv.state.peers[c.peer] for c in group]
    room=srv.state.rooms[peers[0].room_id]
    assert room.room_id==peers[1].room_id and room.room_id not in rooms
    rooms.add(room.room_id)
    for c in group:c.legacy(12,struct.pack("<H",21));c.receive(67,24)
    # Flush prior selection updates before capturing the start sequence.
    for c in group:c.legacy(3);assert c.receive(67,3)==b"\0"
    for c in group:c.legacy(16)
    for i,c in enumerate(group):
     joins=[];start=None
     for _ in range(100):
      size,kind,*_=core.HEADER.unpack(exact(c.s,16));data=exact(c.s,size-16)
      if kind!=67:continue
      pid=struct.unpack_from("<H",data)[0];body=data[6:]
      if pid==60004:joins.append(body)
      if pid==18:start=body;break
     assert start and len(joins)==2
     expected=srv.state.managed_battle.session(peers[i])
     assert struct.unpack_from("<i",joins[0],4)[0]==expected
     assert expected!=c.session,"Fixture must expose the old session mismatch"
     for j,body in enumerate(joins):(fixtures/f"{case}-{i}-group{j}.bin").write_bytes(body)
     (fixtures/f"{case}-{i}-start.bin").write_bytes(start)
     (fixtures/f"{case}-{i}-room.bin").write_bytes(srv.state.managed_battle.roster(room))
    for c in group:c.legacy(19,struct.pack("<i",100))
    assert group[0].receive(67,20)==group[1].receive(67,20)
    for c in group:c.legacy(21);c.legacy(3);assert c.receive(67,3)==b"\0"
    group[0].legacy(60019,struct.pack("<iH",-1,60014)+b"v173-relay")
    assert group[1].receive(67,60014)==b"v173-relay"
    print(f"PASS mode={mode} operation={operation}: isolated room, two-player start/load/relay, bounded self-first Eve sessions")
  finally:
   for c in clients:c.s.close()
   srv.shutdown();srv.server_close()
if __name__=="__main__":
 capture=io.StringIO()
 try:
  with contextlib.redirect_stdout(capture):run()
 except Exception:
  (ROOT/"Recovery/V173ServerVerification.txt").write_text(capture.getvalue()+traceback.format_exc(),encoding="utf-8");raise
 report="\n".join(x for x in capture.getvalue().splitlines() if x.startswith("PASS"))
 (ROOT/"Recovery/V173ServerVerification.txt").write_text(report+"\n",encoding="utf-8")
 print(report)