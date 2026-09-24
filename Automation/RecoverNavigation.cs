// Rebuild from the original navigation detail triangles, including ramp heights.
var report=new System.Text.StringBuilder();
foreach(string sceneName in new[]{"MultiGame","MtmGame"}) {
 string source=System.IO.File.ReadAllText(@"D:\A_KJ\AI\PhoneLOL-Recovery-v11511\ExportedProject\Assets\Scenes\"+sceneName+".unity");
 var oldRef=System.Text.RegularExpressions.Regex.Match(source,@"m_NavMesh: \{fileID: 19400000, guid: (\w+)");
 if(!oldRef.Success)throw new System.Exception("Original navigation is missing: "+sceneName);
 string oldPath=UnityEditor.AssetDatabase.GUIDToAssetPath(oldRef.Groups[1].Value);
 string hex=System.Text.RegularExpressions.Regex.Match(System.IO.File.ReadAllText(oldPath),@"m_MeshData: ([0-9a-fA-F]+)").Groups[1].Value;
 byte[] raw=new byte[hex.Length/2];for(int i=0;i<raw.Length;i++)raw[i]=System.Convert.ToByte(hex.Substring(i*2,2),16);
 var verts=new System.Collections.Generic.List<UnityEngine.Vector3>();
 var triangles=new System.Collections.Generic.List<int>();
 float climb=0;
 using(var reader=new System.IO.BinaryReader(new System.IO.MemoryStream(raw))){
  if(reader.ReadInt32()!=0x4d534554 || reader.ReadInt32()!=1)throw new System.Exception("Unknown navigation container");
  int tiles=reader.ReadInt32();reader.BaseStream.Position=40;
  for(int tile=0;tile<tiles;tile++){
   reader.ReadUInt32();int length=reader.ReadInt32();long start=reader.BaseStream.Position;
   if(reader.ReadInt32()!=0x444e4156 || reader.ReadInt32()!=13)throw new System.Exception("Unknown navigation tile");
   reader.BaseStream.Position=start+24;
   int polyCount=reader.ReadInt32(),vertexCount=reader.ReadInt32(),linkCount=reader.ReadInt32();
   int detailCount=reader.ReadInt32(),detailVertexCount=reader.ReadInt32(),detailTriCount=reader.ReadInt32();
   reader.BaseStream.Position=start+72;climb=UnityEngine.Mathf.Max(climb,reader.ReadSingle());
   reader.BaseStream.Position=start+104;
   var tileVerts=new UnityEngine.Vector3[vertexCount];
   for(int i=0;i<vertexCount;i++)tileVerts[i]=new UnityEngine.Vector3(reader.ReadSingle(),reader.ReadSingle(),reader.ReadSingle());
   var polys=new int[polyCount][];var types=new int[polyCount];
   for(int i=0;i<polyCount;i++){
    long p=reader.BaseStream.Position;reader.ReadUInt32();var ids=new int[6];
    for(int j=0;j<6;j++)ids[j]=reader.ReadUInt16();
    reader.BaseStream.Position=p+32;int count=reader.ReadByte();types[i]=reader.ReadByte()>>6;reader.BaseStream.Position=p+36;
    if(count<2 || count>6)throw new System.Exception("Invalid polygon");
    polys[i]=new int[count];System.Array.Copy(ids,polys[i],count);
   }
   reader.BaseStream.Position+=linkCount*12;
   var bases=new int[detailCount];var triBases=new int[detailCount];var counts=new int[detailCount];var triCounts=new int[detailCount];
   for(int i=0;i<detailCount;i++){
    bases[i]=reader.ReadInt32();triBases[i]=reader.ReadInt32();counts[i]=reader.ReadUInt16();triCounts[i]=reader.ReadUInt16();
   }
   var detailVerts=new UnityEngine.Vector3[detailVertexCount];
   for(int i=0;i<detailVertexCount;i++)detailVerts[i]=new UnityEngine.Vector3(reader.ReadSingle(),reader.ReadSingle(),reader.ReadSingle());
   var detailTris=new int[detailTriCount][];
   for(int i=0;i<detailTriCount;i++){detailTris[i]=new[]{(int)reader.ReadUInt16(),(int)reader.ReadUInt16(),(int)reader.ReadUInt16()};reader.ReadUInt16();}
   for(int p=0;p<detailCount;p++){
    if(types[p]!=0)continue;
    for(int t=0;t<triCounts[p];t++){
     int first=verts.Count;
     foreach(int id in detailTris[triBases[p]+t]){
      if(id>=polys[p].Length+counts[p])throw new System.Exception("Invalid detail vertex");
      verts.Add(id<polys[p].Length?tileVerts[polys[p][id]]:detailVerts[bases[p]+id-polys[p].Length]);
     }
     triangles.Add(first);
     if(UnityEngine.Vector3.Cross(verts[first+1]-verts[first],verts[first+2]-verts[first]).y<0){triangles.Add(first+2);triangles.Add(first+1);}
     else{triangles.Add(first+1);triangles.Add(first+2);}
    }
   }
   reader.BaseStream.Position=start+length;
  }
  if(reader.BaseStream.Position!=raw.Length)throw new System.Exception("Unexpected navigation tail");
 }
 var mesh=new UnityEngine.Mesh {name=sceneName+" original detailed walkable surface"};
 mesh.SetVertices(verts);mesh.SetTriangles(triangles,0);mesh.RecalculateBounds();
 var settings=UnityEngine.AI.NavMesh.GetSettingsByIndex(0);
 // The input already encodes walkability and original obstacle erosion.
 settings.agentRadius=0.01f;settings.agentHeight=1;settings.agentClimb=climb;settings.agentSlope=89;
 settings.overrideVoxelSize=true;settings.voxelSize=0.025f;settings.minRegionArea=0;
 var bounds=mesh.bounds;bounds.Expand(4f);
 var data=UnityEngine.AI.NavMeshBuilder.BuildNavMeshData(settings,new System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>{
 new UnityEngine.AI.NavMeshBuildSource {shape=UnityEngine.AI.NavMeshBuildSourceShape.Mesh,sourceObject=mesh,transform=UnityEngine.Matrix4x4.identity,area=0}},bounds,UnityEngine.Vector3.zero,UnityEngine.Quaternion.identity);
 if(data==null)throw new System.Exception("Navigation bake failed");
 string path="Assets/NavMesh/"+sceneName+"-Unity6.asset";
 var existing=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.AI.NavMeshData>(path);
 if(existing!=null){UnityEditor.EditorUtility.CopySerialized(data,existing);UnityEngine.Object.DestroyImmediate(data);data=existing;UnityEditor.EditorUtility.SetDirty(existing);}
 else UnityEditor.AssetDatabase.CreateAsset(data,path);
 var instance=UnityEngine.AI.NavMesh.AddNavMeshData(data);
 int misses=0;
 try{
  for(int t=0;t<triangles.Count;t+=3){
   var point=(verts[triangles[t]]+verts[triangles[t+1]]+verts[triangles[t+2]])/3f;
   if(!UnityEngine.AI.NavMesh.SamplePosition(point,out var hit,0.3f,-1))misses++;
  }
  var spawn=sceneName=="MultiGame"?new[]{new UnityEngine.Vector3(-28,2,-28),new UnityEngine.Vector3(28,2,28)}:new[]{new UnityEngine.Vector3(-37,0,0),new UnityEngine.Vector3(37,0,0)};
  if(!UnityEngine.AI.NavMesh.SamplePosition(spawn[0],out var from,5f,-1)||!UnityEngine.AI.NavMesh.SamplePosition(spawn[1],out var to,5f,-1))throw new System.Exception("Missing lane endpoint");
  var lane=new UnityEngine.AI.NavMeshPath();
  if(!UnityEngine.AI.NavMesh.CalculatePath(from.position,to.position,-1,lane)||lane.status!=UnityEngine.AI.NavMeshPathStatus.PathComplete)throw new System.Exception("Main lane disconnected");
  report.AppendLine(sceneName+" detailed triangles="+triangles.Count/3+" missing centroids within 0.3="+misses+" lane=complete");
 }finally{instance.Remove();UnityEngine.Object.DestroyImmediate(mesh);}
}
UnityEditor.AssetDatabase.SaveAssets();
System.IO.File.WriteAllText("../Recovery/V11610NavigationRecovery.txt",report.ToString());
return report.ToString();