var report = new System.Text.StringBuilder();
foreach (var path in new[]{"Assets/Scenes/MultiGame.unity","Assets/Scenes/MtmGame.unity"}) {
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene(path,UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try {
  report.AppendLine(path);
  foreach(var root in scene.GetRootGameObjects()) foreach(var t in root.GetComponentsInChildren<UnityEngine.Transform>(true)) {
   if(t.name=="BottomRight" || t.name.ToLower().Contains("attack") || t.name.ToLower().Contains("skillplus")) {
    var widget=t.GetComponent<UIWidget>();var box=t.GetComponent<UnityEngine.BoxCollider>();
    report.AppendLine(t.name+" id="+UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(t).targetObjectId+" parent="+(t.parent==null?"":t.parent.name)+" pos="+t.localPosition+" scale="+t.localScale+" width="+(widget==null?0:widget.get_width())+" collider="+(box==null?"":box.size.ToString()));
   }
   var gm=t.GetComponent<GameManager>();if(gm!=null) { for(byte team=0;team<2;team++){var position=PhoneLOLPracticeGuardSM.GetSpawnPosition(gm.GetTeamPos(team),gm.GetTeamPos(1-team),team);UnityEngine.AI.NavMeshHit hit;bool onNav=UnityEngine.AI.NavMesh.SamplePosition(position,out hit,10f,UnityEngine.AI.NavMesh.AllAreas);report.AppendLine("GUARD "+team+" pos="+position+" nav="+onNav+" nearest="+hit.position); UnityEngine.Physics.SyncTransforms();foreach(var ray in UnityEngine.Physics.RaycastAll(position+UnityEngine.Vector3.up*30,UnityEngine.Vector3.down,60f))report.AppendLine("GROUND "+ray.collider.name+" pos="+ray.point);}}
  }
 }finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
System.IO.File.WriteAllText("../Recovery/V174SceneInspection.txt",report.ToString());
return report.ToString();