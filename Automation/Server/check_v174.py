"""Real socket regression for departed participants and authenticated result settlement."""
import contextlib,io,pathlib,struct,tempfile,threading,traceback
from check_managed_v1167 import Client,server,core
ROOT=pathlib.Path(__file__).resolve().parents[2]
def outcome(room,peers):
 slots={p.visual.slot:p for p in peers}
 data=bytearray(struct.pack("<Bii",0,3,1))
 for slot in range(room.capacity):
  p=slots.get(slot);data+=bytes((p is not None,))
  if p:
   data+=struct.pack("<IH",p.device_id,p.visual.hero_id)+core.encode_text("untrusted display")
   items=[1001]*(8 if room.mode in (10,103) else 5)
   data+=struct.pack("<IBHHHHB"+str(len(items))+"H",0,5,3 if slot%2==0 else 1,1,0,4,0,*items)
 return bytes(data)
def run():
 fixtures=ROOT/".git/v174-fixtures";fixtures.mkdir(exist_ok=True)
 with tempfile.TemporaryDirectory(prefix="phonelol-v174-") as tmp:
  srv=server.build_server("127.0.0.1",0,str(pathlib.Path(tmp)/"test.db"))
  threading.Thread(target=srv.serve_forever,daemon=True).start()
  clients=[]
  try:
   for case,(mode,left,intentional) in enumerate([(20,1,False),(20,0,False),(10,1,False),(10,0,False),(103,1,True),(103,0,True)]):
    pair=[]
    for i in range(2):
     c=Client(srv.server_address[1],991740000+case*10+i);clients.append(c);pair.append(c)
     assert c.rpc(0,25,bytes((mode,3 if mode==103 else 0))+bytes(14))[0]==0
     c.legacy(1,struct.pack("<iIq",79,c.device,c.token));assert c.receive(67,1)[0]==0
     c.legacy(4,bytes((mode,0)));assert c.receive(67,7)[0]==0
    peers=[srv.state.peers[c.peer] for c in pair];room=srv.state.rooms[peers[0].room_id]
    for c in pair:c.legacy(12,struct.pack("<H",21));c.receive(67,24)
    for c in pair:c.legacy(16)
    for c in pair:assert c.receive(67,18)[0]==1
    for c in pair:c.legacy(19,struct.pack("<i",100))
    for c in pair:assert c.receive(67,20)[0]==1
    for c in pair:c.legacy(21);c.legacy(3);assert c.receive(67,3)==b"\0"
    bridge=srv.state.managed_battle
    original=bridge.match_rosters[room.room_id]
    (fixtures/f"{case}-room.bin").write_bytes(bridge.roster(room))
    (fixtures/f"{case}-sessions.bin").write_bytes(struct.pack("<iii",room.room_id,bridge.session(peers[0]),bridge.session(peers[1])))
    body=outcome(room,original)
    pair[1].legacy(22,body);assert pair[1].receive(67,22)==b"\xff"
    gone=pair[left];stay=pair[1-left]
    if intentional:gone.legacy(10);assert gone.receive(67,10)[0]==0
    else:gone.s.shutdown(2);gone.s.close()
    event=stay.receive(67,61002);device,slot,master=struct.unpack("<IBi",event)
    assert device==gone.device and slot==original[left].visual.slot
    assert master==bridge.session(peers[1-left]) and room.host_peer==stay.peer
    (fixtures/f"{case}-departure.bin").write_bytes(event)
    stay.legacy(3);assert stay.receive(67,3)==b"\0"
    # Removing or altering a departed identity must still be rejected.
    stay.legacy(22,outcome(room,[original[1-left]]));assert stay.receive(67,22)==b"\xff"
    tampered=bytearray(body);tampered[10:14]=struct.pack("<I",123)
    stay.legacy(22,bytes(tampered));assert stay.receive(67,22)==b"\xff"
    stay.legacy(22,body);reply=stay.receive(67,22);assert reply[0]==0 and reply!=b"\xff"
    before=[srv.state.account_services.results.stats(srv.state.accounts.get_or_create(c.device).uid) for c in pair]
    if mode==20:
     assert before[0][1][1:4]==(1,0,0) and before[1][1][1:4]==(0,1,0),before
    stay.legacy(22,body);assert stay.receive(67,22)==reply
    assert before==[srv.state.account_services.results.stats(srv.state.accounts.get_or_create(c.device).uid) for c in pair]
    lookup=struct.pack("<QH?ii",room.shared_game_id,21,True,0,0)
    assert len(stay.rpc(0,27,lookup))==85
    assert len(srv.state.account_services.results.result(gone.device,lookup))==85
    print(f"PASS mode={mode} departed={'host' if left==0 else 'guest'} intentional={intentional}: presence/master, win/loss for both, lookup, idempotence, identity/roster/nonhost rejection")
    stay.s.shutdown(2);stay.s.close()
  finally:
   for c in clients:c.s.close()
   srv.shutdown();srv.server_close()
if __name__=="__main__":
 capture=io.StringIO()
 try:
  with contextlib.redirect_stdout(capture):run()
 except Exception:
  (ROOT/"Recovery/V174ServerVerification.txt").write_text(capture.getvalue()+traceback.format_exc(),encoding="utf-8");raise
 report="\n".join(x for x in capture.getvalue().splitlines() if x.startswith("PASS"))
 (ROOT/"Recovery/V174ServerVerification.txt").write_text(report+"\n",encoding="utf-8");print(report)
