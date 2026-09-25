
"""Disposable real-socket stability checks; never touches the live account database."""
import contextlib,io,pathlib,struct,tempfile,threading,time,socket,traceback,concurrent.futures
from check_managed_v1167 import Client,server,core
from check_v174 import outcome
ROOT=pathlib.Path(__file__).resolve().parents[2]
def join(srv, device, mode=103):
 c=Client(srv.server_address[1],device)
 assert c.rpc(0,25,bytes((mode,3 if mode==103 else 0))+bytes(14))[0]==0
 c.legacy(1,struct.pack("<iIq",79,c.device,c.token)); assert c.receive(67,1)[0]==0
 c.legacy(4,bytes((mode,0)));assert c.receive(67,7)[0]==0
 return c
def start(srv,cs):
 for c in cs:c.legacy(12,struct.pack("<H",21));c.receive(67,24)
 for c in cs:c.legacy(16)
 for c in cs:assert c.receive(67,18)[0]==1
def close(c):
 try:c.s.shutdown(socket.SHUT_RDWR)
 except OSError:pass
 c.s.close()
def loading_departure(srv,host_leaves):
 cs=[join(srv,991774000+host_leaves*10+i,20) for i in range(2)]
 try:
  start(srv,cs); stay=cs[1 if host_leaves else 0];gone=cs[0 if host_leaves else 1]
  room=srv.state.rooms[srv.state.peers[stay.peer].room_id]
  roster=srv.state.managed_battle.match_rosters[room.room_id]
  stay.legacy(19,struct.pack("<i",1));stay.receive(67,19)
  close(gone);stay.receive(67,61002);stay.s.settimeout(1)
  assert stay.receive(67,20)[0]==1
  stay.legacy(21);stay.legacy(3);assert stay.receive(67,3)==b"\0"
  stay.legacy(22,outcome(room,roster));assert stay.receive(67,22)[0]==0
  print("PASS loading departure host="+str(host_leaves)+": survivor starts and settles original roster")
 finally:
  for c in cs:close(c)
def transport_id(srv):
 c=Client(srv.server_address[1],991774090)
 try:
  p=srv.state.peers[c.peer]
  # A stale integer object address from an earlier connection must not retire this peer.
  srv.state._retired_peer_objects.add(id(p))
  assert srv.state._pipe_for(p) is not None,"stale object address blocks new connection"
  print("PASS stale retired object address cannot reject a live connection")
 finally:close(c)
def ten_player_relay(srv):
 cs=[join(srv,991774100+i) for i in range(10)]
 try:
  start(srv,cs)
  for c in cs:c.legacy(19,struct.pack("<i",1))
  for c in cs:assert c.receive(67,20)[0]==1
  for c in cs:c.legacy(21);c.legacy(3);assert c.receive(67,3)==b"\0"
  count=120;latencies=[]
  def reader(index,c):
   seen={}
   for _ in range(9*count):
    data=c.receive(67,60016);sender,seq,sent=struct.unpack("<IId",data)
    assert sender!=index and seq==seen.get(sender,0);seen[sender]=seq+1
    latencies.append((time.perf_counter()-sent)*1000)
   assert len(seen)==9 and all(x==count for x in seen.values())
  def writer(index,c):
   for seq in range(count):
    c.legacy(60019,struct.pack("<iH",-1,60016)+struct.pack("<IId",index,seq,time.perf_counter()))
    time.sleep(.01)
  with concurrent.futures.ThreadPoolExecutor(max_workers=20) as pool:
   futures=[pool.submit(reader,i,c) for i,c in enumerate(cs)]+[pool.submit(writer,i,c) for i,c in enumerate(cs)]
   for f in futures:f.result(timeout=25)
  latencies.sort()
  print(f"PASS 10-player relay: {len(latencies)} deliveries, no loss/duplicates/order errors; local p95={latencies[int(len(latencies)*.95)]:.2f}ms max={latencies[-1]:.2f}ms")
  # Explicit opposite-mode room cannot receive this room's payload.
  other=join(srv,991774200,10)
  try:
   peer=srv.state.peers[other.peer]
   assert peer.room_id!=srv.state.peers[cs[0].peer].room_id
   cs[0].legacy(60019,struct.pack("<iH",srv.state.managed_battle.session(peer),60016)+b"must-not-cross-room")
   other.legacy(3);assert other.receive(67,3)==b"\0"
   print("PASS separate mode room and unrelated directed recipient isolation")
  finally:close(other)
 finally:
  for c in cs:close(c)
def slow_peer(srv):
 cs=[join(srv,991775000+i) for i in range(3)]
 try:
  start(srv,cs)
  for c in cs:c.legacy(19,struct.pack("<i",1))
  for c in cs:assert c.receive(67,20)[0]==1
  source,healthy,slow=cs
  slow.s.setsockopt(socket.SOL_SOCKET,socket.SO_RCVBUF,1024)
  sp=srv.state.peers[slow.peer]
  class BlockedWriter:
   # Deterministically emulate a receiver whose TCP writer cannot make progress.
   # Other peers still use real sockets; no live service is involved.
   def __init__(self,sock):self.sock=sock;self.stopped=threading.Event()
   def sendall(self,data):
    self.stopped.wait(15)
    raise OSError("injected blocked receiver")
   def shutdown(self,how):
    self.stopped.set()
    self.sock.shutdown(how)
   def __getattr__(self,name):return getattr(self.sock,name)
  sp.conn=BlockedWriter(sp.conn)
  count=4000
  def read_healthy():
   for i in range(count):
    body=healthy.receive(67,60016);assert struct.unpack_from("<I",body)[0]==i
  with concurrent.futures.ThreadPoolExecutor(max_workers=1) as pool:
   future=pool.submit(read_healthy)
   for i in range(count):
    source.legacy(60019,struct.pack("<iH",-1,60016)+struct.pack("<I",i)+bytes(4092))
    time.sleep(.0005)
   future.result(timeout=20)
  deadline=time.monotonic()+5
  while slow.peer in srv.state.peers and time.monotonic()<deadline:time.sleep(.02)
  assert slow.peer not in srv.state.peers, "slow writer state="+str((server.transport.OUTBOUND_MAX_FRAMES,server.transport.OUTBOUND_MAX_BYTES,[(len(v._frames),v._bytes,v._stopped) for v in srv.state._outbound.values()]))
  source.legacy(3);assert source.receive(67,3)==b"\0"
  healthy.legacy(3);assert healthy.receive(67,3)==b"\0"
  print("PASS injected blocked writer isolated; healthy peer receives all4000 ordered4KB frames and both survivors stay responsive")
 finally:
  for c in cs:close(c)
def churn(srv):
 for i in range(120):
  c=Client(srv.server_address[1],991774300+i);assert c.rpc(0,33,b"\x01") is not None;close(c)
 print("PASS 120 consecutive authenticated TCP connections")
def run(baseline=False):
 capture=io.StringIO(); results=[]
 with tempfile.TemporaryDirectory(prefix="phonelol-v1174-") as tmp:
  srv=server.build_server("127.0.0.1",0,str(pathlib.Path(tmp)/"test.db"));threading.Thread(target=srv.serve_forever,daemon=True).start()
  try:
   with contextlib.redirect_stdout(capture):
    for name,fn in [("loading guest",lambda:loading_departure(srv,False)),("loading host",lambda:loading_departure(srv,True)),("retired address",lambda:transport_id(srv))]+([] if baseline else [("10-player relay",lambda:ten_player_relay(srv)),("blocked receiver",lambda:slow_peer(srv)),("connection churn",lambda:churn(srv))]):
     try:fn();results.append((name,True))
     except Exception as e:
      results.append((name,False));print("FAIL "+name+": "+type(e).__name__+" "+str(e))
      if not baseline:traceback.print_exc(file=capture)
  finally:srv.shutdown();srv.server_close()
 (ROOT/".git/v1174-server-full.txt").write_text(capture.getvalue(),encoding="utf-8")
 report="\n".join(x for x in capture.getvalue().splitlines() if x.startswith(("PASS","FAIL")))
 path=ROOT/("Recovery/V1174ServerBaseline.txt" if baseline else "Recovery/V1174ServerVerification.txt");path.write_text(report+"\n",encoding="utf-8");print(report)
 if not baseline:assert all(ok for _,ok in results),results
if __name__=="__main__":
 import sys
 run("--baseline" in sys.argv)
