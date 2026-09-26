PhoneLOLOfflineSession.Enable();
var endpoint=new PhoneLOLServerSettings { host="203.0.113.1",port=1 };
var report=new System.Text.StringBuilder();
try {
 using(var central=new PhoneLOLTransport.Central(endpoint,123456u)) {
  var account=central.Account();var profile=central.Rpc(0,4,new byte[0]);
  int nameBytes=System.Text.Encoding.UTF8.GetByteCount(UnityEngine.PlayerPrefs.GetString("PhoneLOL.OfflineName","로컬플레이어"));
  if(account[0]!=0||profile.Length!=103+nameBytes||profile[0]!=0)
    throw new System.Exception("Offline account/profile length incorrect "+account.Length+"/"+profile.Length);
  var expected=System.IO.File.ReadAllBytes("../Recovery/V1181OfflineProfileFixture.bin");if(!profile.SequenceEqual(expected))throw new System.Exception("Offline profile differs from recovered P4 contract");
  central.Send(50,new byte[0]);var heroes=central.Receive(51);
  if(heroes[0]!=0||System.BitConverter.ToUInt16(heroes,1)!=191||heroes.Length!=196)
    throw new System.Exception("Offline hero catalog invalid "+heroes.Length);
  var runes=central.Rpc(0,7,new byte[0]);
  if(runes.Length!=470||System.BitConverter.ToUInt16(runes,0)!=58)
    throw new System.Exception("Offline rune inventory invalid "+runes.Length);
  var prepare=central.Rpc(0,25,new byte[]{103,1});
  if(prepare.Length!=17||prepare[0]!=0||prepare[1]!=103)
    throw new System.Exception("Offline URF battle preparation invalid");
  report.AppendLine("PASS offline account, exact profile length, 27 heroes, 58 runes and URF preparation");
  System.Action<ushort,byte[]> send=(pid,body)=>central.Send(66,PhoneLOLTransport.Body(w=>{w.Write(pid);w.Write(0);w.Write(body);}));
  System.Func<ushort,byte[]> recv=(expect)=>{
   var frame=central.ReadFrame();if(frame.kind!=67||System.BitConverter.ToUInt16(frame.payload,0)!=expect)
    throw new System.Exception("Expected offline packet "+expect+", got "+System.BitConverter.ToUInt16(frame.payload,0));
   var body=new byte[frame.payload.Length-6];System.Buffer.BlockCopy(frame.payload,6,body,0,body.Length);return body;
  };
  send(1,PhoneLOLTransport.Body(w=>{w.Write(79);w.Write(123456u);w.Write(118100001L);}));
  if(recv(1)[0]!=0)throw new System.Exception("Offline battle authentication failed");
  send(5,new byte[]{103,0});var player=recv(24);var room=recv(7);
  if(room[0]!=0||room[3+16]!=103)throw new System.Exception("Offline room was not URF");
  send(12,new byte[]{21,0});recv(24);
  send(16,new byte[0]);recv(24);recv(60004);
  var started=recv(18);
  if(started[0]!=1||System.BitConverter.ToUInt16(started,1)!=21||started.Length!=111)
   throw new System.Exception("Offline solo start had no champion or wrong roster");
  send(19,System.BitConverter.GetBytes(100));recv(19);
  var loaded=recv(20);
  if(loaded[0]!=1||loaded.Length!=9)throw new System.Exception("Offline world did not start");
  send(21,new byte[0]);send(22,new byte[]{0,0,0});recv(22);
  report.AppendLine("PASS solo battle login, URF room, champion pick, ready, world loaded, local result");
 }
} finally {PhoneLOLOfflineSession.Disable();}
return report.ToString();
