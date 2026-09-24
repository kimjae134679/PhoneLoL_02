// Verify changed contracts and imported assets without connecting to the live server.
var report = new System.Text.StringBuilder();
var flags = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;
var singleton = typeof(NetworkManager).GetField("MLDPFDAHKHA", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
var previous = singleton.GetValue(null);
var fixture = new UnityEngine.GameObject("V1169 temporary contract fixture"); fixture.SetActive(false);
var network = fixture.AddComponent<NetworkManager>();
var battle = (PNDMCOBIODO)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(PNDMCOBIODO));
var room = new BattleServer.GLAMMOFPCHP();
typeof(PNDMCOBIODO).GetField("IGGBGLPOMAA", flags).SetValue(battle, room);
typeof(NetworkManager).GetField("KIKKPMBKFAF", flags).SetValue(network, battle);
singleton.SetValue(null, network);
try {
 foreach (byte mode in new byte[]{0,10,20,101,102}) {
  room.EHCPMLKEBME=mode;
  int expected=mode==10?8:5;
  var inventory=new KMNJPNBJACF(null);
  if(inventory.OAHFGIGJHHC()!=expected) throw new System.Exception("Wrong inventory capacity");
  var stream=new EveEngine.KCIGFAHFHCH(1024); inventory.DFMCIOHFKOF(stream);
  if(stream.PEHKDMHBIED()!=expected+2) throw new System.Exception("Wrong inventory wire size");
  stream.GBMJNFOEACC(123456789); stream.IKAGBBOMAOP(0);
  var received=new KMNJPNBJACF(null); received.GJPFIPICBAM(stream);
  if(stream.PNBKOPGIHDI()!=123456789) throw new System.Exception("Inventory deserialization lost alignment");
  if(PhoneLOLModeRules.Respawn(300f)!=(mode==10?150f:300f)) throw new System.Exception("Wrong respawn multiplier");
  report.AppendLine("mode="+mode+" slots="+expected+" inventory roundtrip=OK");
 }
 room.EHCPMLKEBME=10;
 foreach(string name in new[]{"MultiGame","MtmGame"}) {
  var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
  try {
   foreach(var root in scene.GetRootGameObjects()) {
    foreach(var lighting in root.GetComponentsInChildren<PhoneLOLLegacyLightmaps>(true)) {
     lighting.Apply(); if(UnityEngine.LightmapSettings.lightmaps.Length!=2) throw new System.Exception("Missing lightmaps");
     foreach(var binding in lighting.bindings) if(binding.renderer==null && binding.terrain==null) throw new System.Exception("Broken lighting binding");
     report.AppendLine(name+" lightmaps=2 bindings="+lighting.bindings.Length);
    }
    foreach(var shop in root.GetComponentsInChildren<UIGameShop>(true)) {
     shop.m_gameItemList=PhoneLOLModeRules.ExpandItems(shop.m_gameItemList);
     if(shop.m_gameItemList.Length!=8) throw new System.Exception("Shop is not eight slots");
    }
    foreach(var hud in root.GetComponentsInChildren<UIGame>(true)) {
     hud.m_gameItemList=PhoneLOLModeRules.ExpandItems(hud.m_gameItemList);
     if(hud.m_gameItemList.Length!=8) throw new System.Exception("HUD is not eight slots");
    }
    foreach(var ui in root.GetComponentsInChildren<UIGameItemUseButtons>(true)) {
     PhoneLOLModeRules.ExpandUseButtons(ui);
     if(ui.m_itemIconList.Length!=8) throw new System.Exception("Use buttons are not eight slots");
     for(int i=0;i<8;i++) if(ui.m_itemIconList[i]==null || ui.m_itemIconBackList[i]==null || ui.m_castableList[i]==null || ui.m_itemCountLabelList[i]==null) throw new System.Exception("Broken item UI reference");
     for(int i=5;i<8;i++) {
      var buttons=ui.m_itemIconList[i].transform.parent.GetComponentsInChildren<UIEventTrigger>(true);
      if(buttons.Length==0 || buttons[0].onPress.Count!=1) throw new System.Exception("Missing extra-slot click callback");
     }
    }
    foreach(var result in root.GetComponentsInChildren<UIGameMultiResultHeroInfo>(true)) {
     result.m_items=PhoneLOLModeRules.ExpandResultItems(result.m_items);
     if(result.m_items.Length!=8) throw new System.Exception("Results are not eight slots");
    }
   }
   var data=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.AI.NavMeshData>("Assets/NavMesh/"+name+"-Unity6.asset");
   if(data==null) throw new System.Exception("Missing recovered navigation");
   var instance=UnityEngine.AI.NavMesh.AddNavMeshData(data);
   try {
    if(name=="MultiGame") for(int team=0;team<2;team++) for(int i=0;i<8;i++) {
     float d=team==0?1f:-1f, offset=(4f-i)*0.75f*d;
     var spawn=new UnityEngine.Vector3(-28f*d+offset,2f,-28f*d+offset);
     if(!UnityEngine.AI.NavMesh.SamplePosition(spawn,out var hit,2f,-1)) throw new System.Exception("Mode minion spawn is off navigation: "+spawn);
    }
   } finally {instance.Remove();}
   report.AppendLine(name+" shop/HUD/use/result UI=8, navigation=OK");
  } finally { UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true); }
 }
 int controllers=0,states=0,transitions=0,missing=0;
 foreach(var path in System.IO.Directory.GetFiles("Assets/AnimatorController", "*.controller")) {
  var controller=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEditor.Animations.AnimatorController>(path);
  foreach(var layer in controller.layers) foreach(var state in layer.stateMachine.states) {
   states++; transitions+=state.state.transitions.Length;
   if(state.state.motion==null) missing++;
  }
  controllers++;
 }
 if(states<316) throw new System.Exception(report.ToString()+"controllers="+controllers+" states="+states+" transitions="+transitions+" null motions="+missing);
 report.AppendLine("controllers="+controllers+" states="+states+" transitions="+transitions+" null motions="+missing);
} finally { singleton.SetValue(null,previous); UnityEngine.Object.DestroyImmediate(fixture); }
System.IO.File.WriteAllText("../Recovery/V1169Verification.txt", report.ToString());
return report.ToString();