
var report=new System.Text.StringBuilder();
int map=0;
foreach(var path in new[]{"Assets/Scenes/MultiGame.unity","Assets/Scenes/MtmGame.unity"}) {
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene(path,UnityEditor.SceneManagement.OpenSceneMode.Additive);
 var marks=new System.Collections.Generic.List<UnityEngine.GameObject>();
 try {
  var gm=scene.GetRootGameObjects().SelectMany(x=>x.GetComponentsInChildren<GameManager>(true)).First();
  UnityEngine.Physics.SyncTransforms();
  report.AppendLine(path+" spawn0="+gm.GetTeamPos(0)+" spawn1="+gm.GetTeamPos(1));
  for(byte team=0;team<2;team++) {
   var spawn=gm.GetTeamPos(team);float side=team==0?1:-1;
   var target=PhoneLOLPracticeGuardSM.GetSpawnPosition(spawn,gm.GetTeamPos(1-team),team);
   UnityEngine.AI.NavMeshHit edge;
   if(!UnityEngine.AI.NavMesh.FindClosestEdge(target,out edge,-1)||edge.distance<1f)throw new System.Exception("Target touches navigation edge");
   var navpath=new UnityEngine.AI.NavMeshPath();
   if(!UnityEngine.AI.NavMesh.CalculatePath(spawn,target,-1,navpath)||navpath.status!=UnityEngine.AI.NavMeshPathStatus.PathComplete)throw new System.Exception("Target unreachable from spawn");
   var delta=target-spawn;if(UnityEngine.Mathf.Abs(delta.x)>12.1f||delta.x*side<9.9f)throw new System.Exception("Target moved away from its base flank");
   report.AppendLine("PASS team="+team+" target="+target+" spawnDistance="+delta.magnitude+" edgeClearance="+edge.distance+" completePath=True");
   foreach(var entry in new[]{new {p=spawn,c=UnityEngine.Color.blue},new {p=PhoneLOLPracticeGuardSM.GetSpawnPosition(spawn,gm.GetTeamPos(1-team),team),c=UnityEngine.Color.red}}) {
    var m=UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Sphere);m.transform.position=entry.p+UnityEngine.Vector3.up*3;m.transform.localScale=UnityEngine.Vector3.one*2;var mat=new UnityEngine.Material(UnityEngine.Shader.Find("Unlit/Color"));mat.color=entry.c;m.GetComponent<UnityEngine.Renderer>().sharedMaterial=mat;marks.Add(m);
   }
  }
  var go=new UnityEngine.GameObject("PlacementInspectCamera"); marks.Add(go);var cam=go.AddComponent<UnityEngine.Camera>();
  cam.transform.position=new UnityEngine.Vector3(0,120,0);cam.transform.rotation=UnityEngine.Quaternion.Euler(90,0,0);cam.orthographic=true;cam.orthographicSize=55;cam.nearClipPlane=.1f;cam.farClipPlane=250;cam.cullingMask=~(1<<5);cam.clearFlags=UnityEngine.CameraClearFlags.SolidColor;cam.backgroundColor=UnityEngine.Color.gray;
  var rt=new UnityEngine.RenderTexture(1024,1024,24);cam.targetTexture=rt;cam.Render();var old=UnityEngine.RenderTexture.active;UnityEngine.RenderTexture.active=rt;var tex=new UnityEngine.Texture2D(1024,1024,UnityEngine.TextureFormat.RGB24,false);tex.ReadPixels(new UnityEngine.Rect(0,0,1024,1024),0,0);tex.Apply();System.IO.File.WriteAllBytes("../.git/v1174-placement-map"+map+".png",tex.EncodeToPNG());UnityEngine.RenderTexture.active=old;cam.targetTexture=null;UnityEngine.Object.DestroyImmediate(tex);UnityEngine.Object.DestroyImmediate(rt);
 }finally {foreach(var m in marks)if(m!=null)UnityEngine.Object.DestroyImmediate(m);UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
 map++;
}
System.IO.File.WriteAllText("../Recovery/V1174PlacementVerification.txt",report.ToString());
return report.ToString();
