var report=new System.Text.StringBuilder();
foreach(var guid in UnityEditor.AssetDatabase.FindAssets("t:Material")) {
 string path=UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
 var mat=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Material>(path);
 if(mat.shader==null || !mat.shader.isSupported || UnityEditor.ShaderUtil.ShaderHasError(mat.shader))
 report.AppendLine("BAD_MATERIAL|"+path+"|"+(mat.shader==null?"null":mat.shader.name));
}
foreach(string name in new[]{"MultiGame","MtmGame"}) {
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try {foreach(var root in scene.GetRootGameObjects()) {
  foreach(var button in root.GetComponentsInChildren<UIGameSkillButton>(true)) {
   var c=button.GetComponent<UnityEngine.BoxCollider>();
   report.AppendLine("SKILL|"+name+"|"+button.name+"|pos="+button.transform.localPosition+"|scale="+button.transform.lossyScale+"|box="+(c==null?"null":c.size.ToString())+"|center="+(c==null?"":c.center.ToString()));
  }
  foreach(var obstacle in root.GetComponentsInChildren<UnityEngine.AI.NavMeshObstacle>(true))
   report.AppendLine("OBSTACLE|"+name+"|"+obstacle.name+"|active="+obstacle.gameObject.activeInHierarchy+"|pos="+obstacle.transform.position+"|size="+obstacle.size+"|center="+obstacle.center+"|carve="+obstacle.carving);
 }
 }finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
System.IO.File.WriteAllText("../Recovery/V11610GameplayAudit.txt",report.ToString());
return report.ToString();