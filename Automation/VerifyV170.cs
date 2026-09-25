UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
EveEngine.NIFAIFOJLFI.LFJBNIDJHOM();
var report=new System.Text.StringBuilder();
var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var statics=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static;
var singleton=typeof(NetworkManager).GetField("MLDPFDAHKHA",statics);
var previous=singleton.GetValue(null);
var fixture=new UnityEngine.GameObject("V170 verification");fixture.SetActive(false);
var network=fixture.AddComponent<NetworkManager>();
var battle=(PNDMCOBIODO)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(PNDMCOBIODO));
typeof(NetworkManager).GetField("KIKKPMBKFAF",flags).SetValue(network,battle);singleton.SetValue(null,network);
try {
 foreach(byte mode in new byte[]{101,102,103}) {
  var probe=System.IO.File.ReadAllBytes("../.git/v170-room-"+mode+".bin");
  var body=new byte[probe.Length+4];System.Buffer.BlockCopy(probe,0,body,0,probe.Length);
  System.Buffer.BlockCopy(System.BitConverter.GetBytes(0x12345678u),0,body,probe.Length,4);
  var encoded=new PhoneLOLTransport.LegacyFrame{pid=24,session=1,payload=body}.Encode();
  var reader=EveEngine.PJEMPFEIOAK.PEFJOMFAOJI();reader.LDNEFFHJNPL();reader.HCBNCGILGEJ(encoded,0,encoded.Length);reader.HIAMPPLHDAN();
  var self=new BattleServer.PBOOPPEPAIK();reader.CAHACMKBJMI(self);
  typeof(PNDMCOBIODO).GetField("CFPANPNKOPM",flags).SetValue(battle,self);
  var room=new BattleServer.GLAMMOFPCHP();typeof(PNDMCOBIODO).GetField("IGGBGLPOMAA",flags).SetValue(battle,room);
  reader.CAHACMKBJMI(room);
  int capacity=mode==101?2:10;
  if(room.IFOLDPBLAGD()!=capacity||room.FMCMCKANEBC().Count!=System.Math.Max(6,capacity)||reader.BMKOKHGAHEC()!=0x12345678u)throw new System.Exception("Actual room decoder lost alignment");
  reader.CDPNLMMNNBD();
  int items=mode==103?8:5;
  if(PhoneLOLModeRules.ItemSlots!=items||new KMNJPNBJACF(null).OAHFGIGJHHC()!=items)throw new System.Exception("Wrong mode inventory");
  report.AppendLine("PASS real client decoder mode="+mode+" seats="+capacity+" slots="+items);
  foreach(string name in new[]{"Lobby","MultiGame","MtmGame"}) {
   var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
   try {foreach(var root in scene.GetRootGameObjects()) {
    foreach(var ui in root.GetComponentsInChildren<UILobbyBattleReady>(true)) {
     ui.m_battleReadyHeroInfos=PhoneLOLRoomLayout.Expand(ui.m_battleReadyHeroInfos,true);
     if(ui.m_battleReadyHeroInfos.Length<capacity)throw new System.Exception("Missing ready seats");
     for(int i=0;i<capacity;i++)if(ui.m_battleReadyHeroInfos[i]==null)throw new System.Exception("Missing seat");
    }
    foreach(var ui in root.GetComponentsInChildren<UIGameInfo>(true)) {
     ui.m_heroInfos=PhoneLOLRoomLayout.Expand(ui.m_heroInfos,false);
     if(ui.m_heroInfos.Length<capacity)throw new System.Exception("Missing scoreboard rows");
     for(int i=0;i<capacity;i++){
      ui.m_heroInfos[i].m_items=PhoneLOLModeRules.ExpandResultItems(ui.m_heroInfos[i].m_items);
      if(ui.m_heroInfos[i].m_items.Length!=items)throw new System.Exception("Missing scoreboard item");
     }
    }
    foreach(var ui in root.GetComponentsInChildren<UIMultiGameResult>(true)) {
     ui.m_resultHeroInfos=PhoneLOLRoomLayout.Expand(ui.m_resultHeroInfos,false);
     if(ui.m_resultHeroInfos.Length<capacity)throw new System.Exception("Missing result rows");
    }
    if(name!="Lobby")foreach(var button in root.GetComponentsInChildren<UIGameSkillButton>(true)){
     var collider=button.GetComponent<UnityEngine.BoxCollider>();UnityEngine.Physics.SyncTransforms();
     if(UnityEngine.Mathf.Abs(button.transform.parent.localScale.x-1.06f)>0.001f)throw new System.Exception("Missing right group scale");
     foreach(float x in new[]{-34f,0f,34f})foreach(float y in new[]{-34f,0f,34f}){
      var p=button.transform.TransformPoint(collider.center+new UnityEngine.Vector3(x,y,0));
      if(!collider.Raycast(new UnityEngine.Ray(p-button.transform.forward*10,button.transform.forward),out var hit,20))throw new System.Exception("Scaled touch miss");
     }
    }
   }}finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
  }
  report.AppendLine("PASS both maps: ready/scoreboard/results and scaled skill hit areas mode="+mode);
 }
 var guard=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.GameObject>("Assets/Resources/practice/Alistar.prefab");
 if(guard==null||guard.GetComponent<PhoneLOLPracticeGuardSM>()==null||guard.GetComponent<Actor>().m_actorType!=Actor.IJJMDPGJAEM.SubHero)throw new System.Exception("Invalid practice guard");
 var projectile=UnityEngine.Resources.Load<UnityEngine.GameObject>("Particle/Turret/attack_missile");
 if(projectile==null)throw new System.Exception("Missing nexus turret projectile");
 var turret=new GameServer.NEFBHKKAMJF();if(!turret.FIGLEPBIEEJ(30002))throw new System.Exception("Turret stats missing");
 var stats=turret.GPNKIAHCKMG.IIJMLJCIJFD();
 if(stats.IIICODNIMNN<=0||stats.LOJEMAMKHFD<=0||stats.LNKFLFOGCCD<=0)throw new System.Exception("Invalid turret attack stats");
 report.AppendLine("PASS practice prefab and nexus projectile/stat bindings; turret range="+stats.IIICODNIMNN+" damage="+stats.LOJEMAMKHFD+" speed="+stats.LNKFLFOGCCD);
 report.AppendLine("iOS module available="+UnityEditor.BuildPipeline.IsBuildTargetSupported(UnityEditor.BuildTargetGroup.iOS,UnityEditor.BuildTarget.iOS));
}finally{singleton.SetValue(null,previous);UnityEngine.Object.DestroyImmediate(fixture);}
System.IO.File.WriteAllText("../Recovery/V170ClientVerification.txt",report.ToString());
return report.ToString();