UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
var report=new System.Text.StringBuilder();
foreach(string name in new[]{"Lobby","MultiGameLoading","MtmGameLoading","MultiGame","MtmGame"}){
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try{foreach(var root in scene.GetRootGameObjects())foreach(var b in root.GetComponentsInChildren<UnityEngine.MonoBehaviour>(true)){
  if(b==null)continue;string t=b.GetType().Name;
  if(t=="UILobbyBattleReady"||t=="UIMultiGameResult"||t=="UIGameInfo"||t.Contains("Loading")){
   report.AppendLine(name+" "+t+" "+b.name);
   foreach(var f in b.GetType().GetFields()){
    var a=f.GetValue(b) as System.Array;if(a==null)continue;
    report.AppendLine("  "+f.Name+" count="+a.Length);
    for(int i=0;i<a.Length;i++)if(a.GetValue(i) is UnityEngine.Component c)report.AppendLine("    "+i+" "+c.name+" pos="+c.transform.localPosition+" scale="+c.transform.localScale+" parent="+c.transform.parent.name);
   }
  }
  if(t=="UIGameSkillButton"&&b.name.Contains("0"))for(var p=b.transform;p!=null;p=p.parent)report.AppendLine(name+" SKILL_CHAIN "+p.name+" pos="+p.localPosition+" scale="+p.localScale);
  if(t=="UIRoot"){var u=(UIRoot)b;report.AppendLine(name+" UIROOT style="+u.scalingStyle+" height="+u.manualHeight+" min="+u.minimumHeight+" max="+u.maximumHeight+" dpi="+u.adjustByDPI);}
 }}finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
System.IO.File.WriteAllText("../Recovery/V170LayoutAudit.txt",report.ToString());
return report.ToString();