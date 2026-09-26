UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceSynchronousImport);
var report=new System.Text.StringBuilder();
int audio=0,materials=0,legacy=0,empty=0,originalNull=0;
foreach(var guid in UnityEditor.AssetDatabase.FindAssets("t:AudioClip",new[]{"Assets/AudioClip/OriginalActorAudio"})){
 var clip=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.AudioClip>(UnityEditor.AssetDatabase.GUIDToAssetPath(guid));
 if(clip==null||clip.length<=0)throw new System.Exception("Invalid recovered audio: "+guid);
 audio++;
}
foreach(var guid in UnityEditor.AssetDatabase.FindAssets("t:Material")){
 var m=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Material>(UnityEditor.AssetDatabase.GUIDToAssetPath(guid));
 if(m.shader==null||!m.shader.isSupported||UnityEditor.ShaderUtil.ShaderHasError(m.shader))throw new System.Exception("Invalid shader: "+m.name);
 materials++;
}
foreach(var guid in UnityEditor.AssetDatabase.FindAssets("t:Prefab",new[]{"Assets/Resources/Particle"})){
 string path=UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
 var prefab=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.GameObject>(path);
 foreach(var renderer in prefab.GetComponentsInChildren<ParticleRenderer>(true)){
  legacy++;if(renderer.materials.Length==0){throw new System.Exception("Missing particle material array: "+path+"|"+renderer.name);}
  foreach(var m in renderer.materials)if(m==null){
   UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(renderer,out string originalGuid,out long fileID);
   string original=System.IO.File.ReadAllText(@"D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject\"+path);
   string block=System.Text.RegularExpressions.Regex.Match(original,@"(?ms)^--- !u!26 &"+fileID+@"\r?\n.*?(?=^---|\z)").Value;
   if(!block.Contains("- {fileID: 0}"))throw new System.Exception("Unexpected missing particle material: "+path);
   originalNull++;
  }
 }
 foreach(var renderer in prefab.GetComponentsInChildren<UnityEngine.Renderer>(true))
 foreach(var m in renderer.sharedMaterials)if(m==null)throw new System.Exception("Missing renderer material: "+path);
}
foreach(float scale in new[]{0.1f,1f,3f}){
 var go=new UnityEngine.GameObject("Particle scale verification");
 try{
  go.transform.localScale=UnityEngine.Vector3.one*scale;
  var emitter=go.AddComponent<EllipsoidParticleEmitter>();emitter.emit=false;emitter.minSize=emitter.maxSize=2f;emitter.minEnergy=emitter.maxEnergy=10f;
  emitter.Emit(1);
  var ps=go.GetComponent<UnityEngine.ParticleSystem>();var parts=new UnityEngine.ParticleSystem.Particle[2];
  if(ps.GetParticles(parts)!=1||UnityEngine.Mathf.Abs(parts[0].GetCurrentSize(ps)-2f)>0.001f||ps.main.scalingMode!=UnityEngine.ParticleSystemScalingMode.Shape)throw new System.Exception("Particle size scaled twice");
 }finally{UnityEngine.Object.DestroyImmediate(go);}
}
int taps=0;
foreach(string sceneName in new[]{"MultiGame","MtmGame"}){
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+sceneName+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try{
 foreach(var root in scene.GetRootGameObjects())foreach(var maps in root.GetComponentsInChildren<PhoneLOLLegacyLightmaps>(true))maps.Apply();
 foreach(var root in scene.GetRootGameObjects())foreach(var light in root.GetComponentsInChildren<UnityEngine.Light>(true))
 if(light.lightmapBakeType==UnityEngine.LightmapBakeType.Baked && !light.bakingOutput.isBaked)throw new System.Exception("Original baked light became realtime");
 foreach(var root in scene.GetRootGameObjects())foreach(var button in root.GetComponentsInChildren<UIGameSkillButton>(true)){
  var collider=button.GetComponent<UnityEngine.BoxCollider>();
  if(collider==null||collider.size.x!=70||collider.size.y!=70)throw new System.Exception("Original skill touch bounds changed");
  UnityEngine.Physics.SyncTransforms();
  foreach(float x in new[]{-34f,0f,34f})foreach(float y in new[]{-34f,0f,34f}){
   var point=button.transform.TransformPoint(collider.center+new UnityEngine.Vector3(x,y,0));
   var ray=new UnityEngine.Ray(point-button.transform.forward*10,button.transform.forward);
   if(!collider.Raycast(ray,out var hit,20))throw new System.Exception("Skill collider missed original bounds: "+button.name+" "+x+","+y);
   taps++;
  }
 }}finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
report.AppendLine("PASS audio imports="+audio+" material shaders="+materials+" legacy particle renderers="+legacy+" empty particle material arrays="+empty+" original null material slots="+originalNull);
report.AppendLine("PASS original baked-light state; particle size ownership at 0.1/1/3 transform scale; original skill bounds raycasts="+taps);
System.IO.File.WriteAllText("../Recovery/V11610GameplayVerification.txt",report.ToString());
return report.ToString();