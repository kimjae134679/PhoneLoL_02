var report=new System.Text.StringBuilder();
foreach(string name in new[]{"MultiGame","MtmGame"}) {
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try {
  report.AppendLine(name+" lightmaps="+UnityEngine.LightmapSettings.lightmaps.Length+" mode="+UnityEngine.LightmapSettings.lightmapsMode);
  int count=0;
  foreach(var root in scene.GetRootGameObjects()) foreach(var renderer in root.GetComponentsInChildren<UnityEngine.MeshRenderer>(true)) {
   var mesh=renderer.GetComponent<UnityEngine.MeshFilter>()?.sharedMesh;
   if(mesh==null || !UnityEditor.AssetDatabase.GetAssetPath(mesh).Contains("RecoveredStaticBatches"))continue;
   if(count++>=4)continue;
   var uv=mesh.uv2;var min=UnityEngine.Vector2.one*100000;var max=-min;
   foreach(var p in uv){min=UnityEngine.Vector2.Min(min,p);max=UnityEngine.Vector2.Max(max,p);}
   report.AppendLine(renderer.name+" index="+renderer.lightmapIndex+" ST="+renderer.lightmapScaleOffset+" uv2="+min+".."+max);
  }
 }finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
return report.ToString();