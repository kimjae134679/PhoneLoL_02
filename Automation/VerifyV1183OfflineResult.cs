PhoneLOLOfflineSession.Enable();
var trace=new System.Text.StringBuilder();
var settings=new PhoneLOLServerSettings { host="203.0.113.1",port=1 };
PhoneLOLLocalHost host=null;
try {
 host=new PhoneLOLLocalHost(settings);
 System.Func<int,System.Net.Sockets.TcpClient> connect=port=>{
  var c=new System.Net.Sockets.TcpClient("127.0.0.1",port);c.ReceiveTimeout=4000;c.SendTimeout=4000;return c;
 };
 System.Action<System.Net.Sockets.NetworkStream,ushort,byte[]> send=(stream,pid,body)=>{
  var bytes=new PhoneLOLTransport.LegacyFrame{pid=pid,payload=body}.Encode();
  stream.Write(bytes,0,bytes.Length);
 };
 System.Func<System.Net.Sockets.NetworkStream,ushort,byte[]> recv=(stream,pid)=>{
  var frame=PhoneLOLTransport.LegacyFrame.Read(stream);
  if(frame.pid!=pid)throw new System.Exception("Expected pid "+pid+" got "+frame.pid);
  return frame.payload;
 };
 byte[] hand=PhoneLOLTransport.Body(w=>{w.Write(107);w.Write(777L);w.Write((byte)0);});
 byte[] auth=PhoneLOLTransport.Body(w=>{w.Write(24);w.Write(new byte[]{1,2,3,4,5,6});});
 uint device=PhoneLOLTransport.LegacyDeviceId(auth);
 using(var login=connect(20000)) {
  var stream=login.GetStream();send(stream,60001,hand);
  if(recv(stream,60001)[0]!=0)throw new System.Exception("Login handshake failed");
  send(stream,1,auth);var accepted=recv(stream,1);
  if(accepted[0]!=0||System.BitConverter.ToUInt32(accepted,1)!=device)throw new System.Exception("Offline login failed");
  long token=System.BitConverter.ToInt64(accepted,5);
  trace.AppendLine("PASS localhost login while central endpoint is unreachable");
  using(var game=connect(20001)) {
   var g=game.GetStream();send(g,60001,hand);recv(g,60001);
   send(g,1,PhoneLOLTransport.Body(w=>{w.Write(160);w.Write(device);w.Write(token);}));
   if(recv(g,1)[0]!=0)throw new System.Exception("Game authentication failed");
   send(g,4,new byte[0]);var profile=recv(g,4);
   if(profile[0]!=0||profile.Length<103)throw new System.Exception("Offline game profile failed");
   recv(g,7);recv(g,5);recv(g,12);send(g,25,new byte[]{103,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0});if(recv(g,25)[0]!=0)throw new System.Exception("URF preparation failed");
   trace.AppendLine("PASS localhost game bootstrap profile, runes, owned champions");
  }
  using(var battle=connect(20002)) {
   var b=battle.GetStream();send(b,60001,hand);recv(b,60001);
   send(b,1,PhoneLOLTransport.Body(w=>{w.Write(79);w.Write(device);w.Write(token);}));
   if(recv(b,1)[0]!=0)throw new System.Exception("Battle authentication failed");
   send(b,5,new byte[]{103,0});recv(b,24);
   var room=recv(b,7);if(room[0]!=0||room[19]!=103)throw new System.Exception("Offline room failed");
   send(b,12,new byte[]{21,0});recv(b,24);
   send(b,16,new byte[0]);recv(b,24);recv(b,60004);recv(b,18);
   send(b,19,System.BitConverter.GetBytes(100));recv(b,19);
   var started=recv(b,20);if(started[0]!=1)throw new System.Exception("Offline world load failed");
   ulong match=System.BitConverter.ToUInt64(started,1);
   trace.AppendLine("PASS localhost solo battle champion select, ready and start");
   using(var history=connect(20001)) {
    var h=history.GetStream();send(h,60001,hand);recv(h,60001);
    send(h,1,PhoneLOLTransport.Body(w=>{w.Write(160);w.Write(device);w.Write(token);}));
    if(recv(h,1)[0]!=0)throw new System.Exception("Result lookup login failed");
    System.Func<ulong,byte[]> query=id=>PhoneLOLTransport.Body(w=>{w.Write(id);w.Write((ushort)21);w.Write(new byte[9]);});
    send(h,27,query(match));if(recv(h,27)[0]!=255)throw new System.Exception("Result exists before battle ended");
    var submitted=PhoneLOLTransport.Body(w=>{
     w.Write((byte)0);w.Write(0);w.Write(0);
     for(int slot=0;slot<10;slot++) {
      bool present=slot==0;w.Write(present);
      if(present) {
       w.Write(device);w.Write((ushort)21);
       var name=System.Text.Encoding.UTF8.GetBytes("로컬플레이어");
       w.Write((ushort)name.Length);w.Write(name);
       w.Write(0u);w.Write((byte)3);
       for(int i=0;i<4;i++)w.Write((ushort)0);
       w.Write((byte)0);for(int i=0;i<8;i++)w.Write((ushort)0);
      }
     }
    });
    send(b,21,new byte[0]);
    send(b,22,submitted);
    var acceptedResult=recv(b,22);
    if(!System.Linq.Enumerable.SequenceEqual(acceptedResult,submitted))throw new System.Exception("Result broadcast differs from submitted local result");
    send(h,27,query(match));
    var result=recv(h,27);
    if(result.Length!=85||System.BitConverter.ToInt32(result,0)<1||result[25]!=99)
      throw new System.Exception("Offline match result lookup invalid");
    send(h,27,query(match+1));
    if(recv(h,27)[0]!=255)throw new System.Exception("Wrong match accepted");
    trace.AppendLine("PASS offline solo world initialized, result submitted, 85-byte match lookup");
   }
  }
 }
} finally { if(host!=null)host.Dispose();PhoneLOLOfflineSession.Disable(); }
return trace.ToString();
