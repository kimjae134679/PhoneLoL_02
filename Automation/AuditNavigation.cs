var report=new System.Text.StringBuilder();
foreach(var sceneName in new[]{"MultiGame","MtmGame"}) {
 string source=System.IO.File.ReadAllText(@"D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject\Assets\Scenes\"+sceneName+".unity");
 var match=System.Text.RegularExpressions.Regex.Match(source,@"m_NavMesh: \{fileID: 19400000, guid: (\w+)");
 string oldPath=UnityEditor.AssetDatabase.GUIDToAssetPath(match.Groups[1].Value);
 string hex=System.Text.RegularExpressions.Regex.Match(System.IO.File.ReadAllText(oldPath),@"m_MeshData: ([0-9a-fA-F]+)").Groups[1].Value;
 byte[] raw=new byte[hex.Length/2];for(int i=0;i<raw.Length;i++)raw[i]=System.Convert.ToByte(hex.Substring(i*2,2),16);
 var points=new System.Collections.Generic.List<UnityEngine.Vector3>();
 using(var reader=new System.IO.BinaryReader(new System.IO.MemoryStream(raw))){
  reader.BaseStream.Position=8;int tileCount=reader.ReadInt32();reader.BaseStream.Position=40;
  for(int t=0;t<tileCount;t++){
   reader.ReadUInt32();int len=reader.ReadInt32();long start=reader.BaseStream.Position;
   reader.BaseStream.Position=start+24;int polyCount=reader.ReadInt32(),vertexCount=reader.ReadInt32();
   reader.BaseStream.Position=start+104;var verts=new UnityEngine.Vector3[vertexCount];
   for(int i=0;i<vertexCount;i++)verts[i]=new UnityEngine.Vector3(reader.ReadSingle(),reader.ReadSingle(),reader.ReadSingle());
   for(int i=0;i<polyCount;i++){
    long p=reader.BaseStream.Position;reader.ReadUInt32();var ids=new int[6];for(int j=0;j<6;j++)ids[j]=reader.ReadUInt16();
    reader.BaseStream.Position=p+32;int count=reader.ReadByte(),type=reader.ReadByte()>>6;reader.BaseStream.Position=p+36;
    if(type!=0)continue;
    for(int j=1;j<count-1;j++) points.Add((verts[ids[0]]+verts[ids[j]]+verts[ids[j+1]])/3f);
   }
   reader.BaseStream.Position=start+len;
  }
 }
 var data=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.AI.NavMeshData>("Assets/NavMesh/"+sceneName+"-Unity6.asset");
 var instance=UnityEngine.AI.NavMesh.AddNavMeshData(data);
 int missing=0;float max=0;var samples=new System.Text.StringBuilder();
 try{foreach(var p in points){
  if(!UnityEngine.AI.NavMesh.SamplePosition(p,out var hit,0.3f,-1)){
   missing++;if(missing<=30)samples.AppendLine("MISSING|"+p);
  }else max=UnityEngine.Mathf.Max(max,hit.distance);
 }}finally{instance.Remove();}
 report.AppendLine(sceneName+" original triangle centroids="+points.Count+" missing within 0.3="+missing+" max distance="+max);
 report.Append(samples);
}
foreach(string name in new[]{"MultiGame","MtmGame"}){
 var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
 try{foreach(var root in scene.GetRootGameObjects())foreach(var t in root.GetComponentsInChildren<UnityEngine.Terrain>(true))
 report.AppendLine("TERRAIN|"+name+"|"+t.name+"|material="+(t.materialTemplate==null?"default":t.materialTemplate.shader.name)+"|layers="+t.terrainData.terrainLayers.Length+"|lm="+t.lightmapIndex);
 }finally{UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true);}
}
System.IO.File.WriteAllText("../Recovery/V11610NavigationAudit.txt",report.ToString());
return report.ToString();