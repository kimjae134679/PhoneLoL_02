var report=new System.Text.StringBuilder();
foreach(string name in new[]{"MultiGame","MtmGame"}) {
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try {
  var counts=new System.Collections.Generic.Dictionary<string,int>();
  foreach(var root in scene.GetRootGameObjects()) foreach(var renderer in root.GetComponentsInChildren<UnityEngine.Renderer>(true))
   foreach(var mat in renderer.sharedMaterials) if(mat!=null) {string key=mat.shader.name;counts[key]=counts.ContainsKey(key)?counts[key]+1:1;}
  report.AppendLine(name+" navigation triangles="+UnityEngine.AI.NavMesh.CalculateTriangulation().indices.Length/3);
  foreach(var pair in counts)report.AppendLine(pair.Key+"="+pair.Value);
  foreach(var root in scene.GetRootGameObjects()) foreach(var terrain in root.GetComponentsInChildren<UnityEngine.Terrain>(true))
   report.AppendLine("terrain="+terrain.name+" data="+UnityEditor.AssetDatabase.GetAssetPath(terrain.terrainData)+" size="+terrain.terrainData.size);
 }finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
return report.ToString();