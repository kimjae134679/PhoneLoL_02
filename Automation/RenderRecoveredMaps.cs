UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
var paths=new System.Collections.Generic.List<string>();
foreach(string name in new[]{"MultiGame","MtmGame"}){
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 UnityEngine.RenderTexture rt=null;UnityEngine.Texture2D png=null;UnityEngine.GameObject cameraObject=null;
 var active=UnityEngine.RenderTexture.active;
 try{
  foreach(var root in scene.GetRootGameObjects())foreach(var lm in root.GetComponentsInChildren<PhoneLOLLegacyLightmaps>(true))lm.Apply();
  cameraObject=new UnityEngine.GameObject("Recovery visual verification");var camera=cameraObject.AddComponent<UnityEngine.Camera>();
  camera.transform.position=new UnityEngine.Vector3(0,55,-48);camera.transform.LookAt(new UnityEngine.Vector3(0,1,0));
  camera.orthographic=true;camera.orthographicSize=name=="MultiGame"?45:34;
  camera.cullingMask=~(1<<5);camera.clearFlags=UnityEngine.CameraClearFlags.SolidColor;camera.backgroundColor=UnityEngine.Color.black;
  rt=new UnityEngine.RenderTexture(1000,750,24);camera.targetTexture=rt;camera.Render();
  UnityEngine.RenderTexture.active=rt;png=new UnityEngine.Texture2D(1000,750,UnityEngine.TextureFormat.RGB24,false);
  png.ReadPixels(new UnityEngine.Rect(0,0,1000,750),0,0);png.Apply();
  string path="../.git/"+name+"-visual.png";System.IO.File.WriteAllBytes(path,png.EncodeToPNG());paths.Add(path);
 }finally{
  UnityEngine.RenderTexture.active=active;
  if(cameraObject!=null)UnityEngine.Object.DestroyImmediate(cameraObject);
  if(rt!=null)UnityEngine.Object.DestroyImmediate(rt);
  if(png!=null)UnityEngine.Object.DestroyImmediate(png);
  UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);
 }
}
return string.Join("\n",paths);