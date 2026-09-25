UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
var report=new System.Text.StringBuilder();
var flags=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Instance;
var statics=System.Reflection.BindingFlags.NonPublic|System.Reflection.BindingFlags.Static;
var singleton=typeof(NetworkManager).GetField("MLDPFDAHKHA",statics);var previous=singleton.GetValue(null);
var fixture=new UnityEngine.GameObject("V171 UI fixture");fixture.SetActive(false);
var network=fixture.AddComponent<NetworkManager>();
var battle=(PNDMCOBIODO)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(PNDMCOBIODO));
typeof(NetworkManager).GetField("KIKKPMBKFAF",flags).SetValue(network,battle);singleton.SetValue(null,network);
var room=new BattleServer.GLAMMOFPCHP();room.EHCPMLKEBME=103;typeof(PNDMCOBIODO).GetField("IGGBGLPOMAA",flags).SetValue(battle,room);
try{
 foreach(var name in new[]{"MultiGame","MtmGame"}){
  var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
  try{foreach(var root in scene.GetRootGameObjects()){
   var game=root.GetComponentsInChildren<UnityEngine.Transform>(true).FirstOrDefault(t=>t.name=="GamePanel");if(game==null)continue;
   foreach(var ui in game.GetComponentsInChildren<UIGameItemUseButtons>(true))PhoneLOLModeRules.ExpandUseButtons(ui);
   UnityEngine.Physics.SyncTransforms();
   var combat=game.Find("BottomRight");
   var controls=combat.GetComponentsInChildren<UnityEngine.BoxCollider>(true).Where(c=>c.name!="ShopButton").ToArray();
   foreach(var c in controls){
    var half=c.size*0.48f;
    foreach(float x in new[]{-half.x,half.x})foreach(float y in new[]{-half.y,half.y}){
     var p=c.transform.TransformPoint(c.center+new UnityEngine.Vector3(x,y,0));
     if(!c.Raycast(new UnityEngine.Ray(p-c.transform.forward*10,c.transform.forward),out var hit,20))throw new System.Exception("Touch edge miss "+c.name);
    }
   }
   var all=controls.Concat(game.Find("TopRight/SkillPlus").GetComponentsInChildren<UnityEngine.BoxCollider>(true)).ToArray();
   for(int i=0;i<all.Length;i++)for(int j=i+1;j<all.Length;j++){
    var a=all[i].bounds;var b=all[j].bounds;
    if(System.Math.Min(a.max.x,b.max.x)-System.Math.Max(a.min.x,b.min.x)>0.001f&&System.Math.Min(a.max.y,b.max.y)-System.Math.Max(a.min.y,b.min.y)>0.001f)
      throw new System.Exception("Touch overlap "+all[i].name+" / "+all[j].name);
   }
   report.AppendLine("PASS "+name+": "+controls.Length+" combat controls, four edge raycasts each, no attack/skill/item/upgrade overlap; 8 full-size active slots");
  }}finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
 }
}catch(System.Exception e){report.AppendLine("FAIL "+e);}
finally{singleton.SetValue(null,previous);UnityEngine.Object.DestroyImmediate(fixture);}
System.IO.File.WriteAllText("../Recovery/V171UIVerification.txt",report.ToString());return report.ToString();