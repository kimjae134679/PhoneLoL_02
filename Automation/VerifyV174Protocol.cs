EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var statics=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static;
var root=new UnityEngine.GameObject("V174 protocol fixture");root.SetActive(false);
var ns=typeof(NetworkManager).GetField("MLDPFDAHKHA",statics);var es=typeof(EveUnityNetwork).GetField("MLDPFDAHKHA",statics);
var oldN=ns.GetValue(null);var oldE=es.GetValue(null);
var net=root.AddComponent<NetworkManager>();ns.SetValue(null,net);
var eve=root.AddComponent<EveUnityNetwork>();es.SetValue(null,eve);
System.Func<ushort,byte[],EveEngine.PJEMPFEIOAK> read=(pid,body)=>{
 var wire=new PhoneLOLTransport.LegacyFrame{pid=pid,session=1,payload=body}.Encode();
 var packet=EveEngine.PJEMPFEIOAK.PEFJOMFAOJI();packet.LDNEFFHJNPL();packet.HCBNCGILGEJ(wire,0,wire.Length);packet.HIAMPPLHDAN();return packet;
};
try{
 for(int c=0;c<6;c++){
  var battle=new PNDMCOBIODO();typeof(NetworkManager).GetField("KIKKPMBKFAF",flags).SetValue(net,battle);eve.SetNetClient(battle);
  var bytes=System.IO.File.ReadAllBytes("../.git/v174-fixtures/"+c+"-sessions.bin");
  int roomID=System.BitConverter.ToInt32(bytes,0),s0=System.BitConverter.ToInt32(bytes,4),s1=System.BitConverter.ToInt32(bytes,8);
  int own=c%2==0?s0:s1;typeof(EveEngine.EKACODPEIIO).GetField("NMPLJHGLHBN",flags).SetValue(battle,own);
  var roster=read(24,System.IO.File.ReadAllBytes("../.git/v174-fixtures/"+c+"-room.bin"));roster.CAHACMKBJMI(battle.IMKOGBNIJBO());roster.CDPNLMMNNBD();
  foreach(int session in new[]{own,own==s0?s1:s0}){
   var ms=new System.IO.MemoryStream();var w=new System.IO.BinaryWriter(ms);w.Write(roomID);w.Write(session);w.Write(s0);
   for(int k=0;k<2;k++){w.Write(new byte[]{127,0,0,1});w.Write((ushort)20002);}
   var packet=read(60004,ms.ToArray());typeof(EveEngine.EKACODPEIIO).GetMethod("LNHMLJJCMMH",flags).Invoke(battle,new object[]{packet});packet.CDPNLMMNNBD();
  }
  var body=System.IO.File.ReadAllBytes("../.git/v174-fixtures/"+c+"-departure.bin");byte slot=body[4];var member=battle.IMKOGBNIJBO().FMCMCKANEBC()[slot];
  string name=member.IDANKJFFHFH;uint device=member.GBGKGJKBPHM;ushort hero=member.FPFIIDFCLOL;
  if(member.MNHIDGANMFO())throw new System.Exception("Fixture already offline");
  var departure=read(61002,body);typeof(PNDMCOBIODO).GetMethod("OnManagedDeparture",flags).Invoke(battle,new object[]{departure});departure.CDPNLMMNNBD();
  if(!member.MNHIDGANMFO()||member.GBGKGJKBPHM!=device||member.IDANKJFFHFH!=name||member.FPFIIDFCLOL!=hero)throw new System.Exception("Departure lost identity");
  if(eve.GetDefaultGroup().ACCPGHNBJOL()!=System.BitConverter.ToInt32(body,5))throw new System.Exception("Master not transferred");
  report.AppendLine("PASS departure "+c+": offline flag, nickname/hero/device preserved, Eve master updated");
 }
 foreach(var type in new[]{typeof(MultiGameManager),typeof(MtmGameManager)}){
  var go=new UnityEngine.GameObject(type.Name);go.SetActive(false);go.transform.parent=root.transform;var gm=(GameManager)go.AddComponent(type);
  var idle=type.GetField("m_actionElapsedTime");idle.SetValue(gm,10000f);
  var notice=new UnityEngine.GameObject("idle notice");notice.transform.parent=go.transform;
  type.GetField("m_mainDescription").SetValue(gm,notice);
  type.GetMethod("NCNGMLHNAJB",flags).Invoke(gm,null);
  if((float)idle.GetValue(gm)!=0||notice.activeSelf)throw new System.Exception("Idle kick not disabled");
 }
 report.AppendLine("PASS both game managers remain connected after a simulated 10000 seconds idle");
 var errors=new System.Collections.Generic.List<string>();
 UnityEngine.Application.LogCallback capture=(message,trace,type)=>{if(type==UnityEngine.LogType.Error)errors.Add(message);};
 UnityEngine.Application.logMessageReceived+=capture;
 try {
  PhoneLOLRuntimeServices.CriticalError("V174_TEST_CONFIRMED_DISCONNECT");
  var services=UnityEngine.Object.FindFirstObjectByType<PhoneLOLRuntimeServices>();
  typeof(PhoneLOLRuntimeServices).GetMethod("Update",flags).Invoke(services,null);
  report.AppendLine("CONSOLE enabled="+UnityEngine.Debug.developerConsoleEnabled+" visible="+UnityEngine.Debug.developerConsoleVisible+" captured="+errors.Contains("V174_TEST_CONFIRMED_DISCONNECT")); if(!errors.Contains("V174_TEST_CONFIRMED_DISCONNECT"))throw new System.Exception("Error log missing");
 }finally{UnityEngine.Application.logMessageReceived-=capture;UnityEngine.Debug.developerConsoleVisible=false;}
 report.AppendLine("PASS critical connection error emits Error log; native developer-console visibility requires Player verification");
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{ns.SetValue(null,oldN);es.SetValue(null,oldE);UnityEngine.Object.DestroyImmediate(root);}
System.IO.File.WriteAllText("../Recovery/V174ProtocolVerification.txt",report.ToString());return report.ToString();