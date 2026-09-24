// Rebuild Unity 6 navigation from the original baked walkable polygons.
// This preserves the original walls and lanes instead of treating visual scenery as walkable.
var report = new System.Text.StringBuilder();
foreach (string sceneName in new[] { "MultiGame", "MtmGame" }) {
    string scenePath="Assets/Scenes/"+sceneName+".unity";
    string yaml=System.IO.File.ReadAllText(scenePath);
    var oldRef=System.Text.RegularExpressions.Regex.Match(yaml,@"m_NavMesh: \{fileID: 19400000, guid: (\w+), type: 2\}");
    if(!oldRef.Success) throw new System.Exception("Original navigation reference missing: "+sceneName);
    string oldPath=UnityEditor.AssetDatabase.GUIDToAssetPath(oldRef.Groups[1].Value);
    string oldYaml=System.IO.File.ReadAllText(oldPath);
    string hex=System.Text.RegularExpressions.Regex.Match(oldYaml,@"m_MeshData: ([0-9a-fA-F]+)").Groups[1].Value;
    byte[] raw=new byte[hex.Length/2];
    for(int i=0;i<raw.Length;i++) raw[i]=System.Convert.ToByte(hex.Substring(i*2,2),16);
    var verts=new System.Collections.Generic.List<UnityEngine.Vector3>();
    var triangles=new System.Collections.Generic.List<int>();
    using(var reader=new System.IO.BinaryReader(new System.IO.MemoryStream(raw))) {
        if(reader.ReadInt32()!=0x4d534554 || reader.ReadInt32()!=1) throw new System.Exception("Unknown legacy navigation container");
        int tileCount=reader.ReadInt32();
        reader.BaseStream.Position=40;
        for(int tile=0;tile<tileCount;tile++) {
            reader.ReadUInt32(); int length=reader.ReadInt32(); long start=reader.BaseStream.Position;
            if(reader.ReadInt32()!=0x444e4156 || reader.ReadInt32()!=13) throw new System.Exception("Unknown legacy tile");
            reader.BaseStream.Position=start+24;
            int polyCount=reader.ReadInt32(),vertexCount=reader.ReadInt32();
            reader.BaseStream.Position=start+104;
            int first=verts.Count;
            for(int i=0;i<vertexCount;i++) verts.Add(new UnityEngine.Vector3(reader.ReadSingle(),reader.ReadSingle(),reader.ReadSingle()));
            for(int i=0;i<polyCount;i++) {
                long poly=reader.BaseStream.Position; reader.ReadUInt32();
                var ids=new int[6];for(int j=0;j<6;j++) ids[j]=reader.ReadUInt16();
                reader.BaseStream.Position=poly+32;int count=reader.ReadByte(); int type=reader.ReadByte()>>6;
                reader.BaseStream.Position=poly+36;
                if(type!=0) continue;
                if(count<3 || count>6) throw new System.Exception("Invalid legacy polygon");
                for(int j=0;j<count;j++) if(ids[j]>=vertexCount) throw new System.Exception("Invalid polygon vertex");
                for(int j=1;j<count-1;j++) {
                    int a=first+ids[0],b=first+ids[j],c=first+ids[j+1];
                    if(UnityEngine.Vector3.Cross(verts[b]-verts[a],verts[c]-verts[a]).y<0) { int swap=b;b=c;c=swap; }
                    triangles.Add(a);triangles.Add(b);triangles.Add(c);
                }
            }
            reader.BaseStream.Position=start+length;
        }
        if(reader.BaseStream.Position!=raw.Length) throw new System.Exception("Unexpected legacy navigation tail");
    }
    var mesh=new UnityEngine.Mesh { name=sceneName+" original walkable polygons" };
    mesh.SetVertices(verts);mesh.SetTriangles(triangles,0);mesh.RecalculateBounds();
    var settings=UnityEngine.AI.NavMesh.GetSettingsByIndex(0);
    // The input was already eroded for the original agent radius.
    settings.agentRadius=0.01f;settings.agentHeight=1f;settings.agentClimb=0.5f;settings.agentSlope=45f;
    settings.overrideVoxelSize=true;settings.voxelSize=0.05f;settings.minRegionArea=0f;
    var source=new UnityEngine.AI.NavMeshBuildSource { shape=UnityEngine.AI.NavMeshBuildSourceShape.Mesh,
        sourceObject=mesh,transform=UnityEngine.Matrix4x4.identity,area=0 };
    var bounds=mesh.bounds;bounds.Expand(4f);
    var data=UnityEngine.AI.NavMeshBuilder.BuildNavMeshData(settings,
        new System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>{source},bounds,UnityEngine.Vector3.zero,UnityEngine.Quaternion.identity);
    if(data==null) throw new System.Exception("Navigation bake failed: "+sceneName);
    string path="Assets/NavMesh/"+sceneName+"-Unity6.asset";
    UnityEditor.AssetDatabase.CreateAsset(data,path);
    var instance=UnityEngine.AI.NavMesh.AddNavMeshData(data);
    try {
        var triangulation=UnityEngine.AI.NavMesh.CalculateTriangulation();
        if(triangulation.indices.Length==0) throw new System.Exception("Empty navigation: "+sceneName);
        var points=sceneName=="MultiGame" ? new[]{new UnityEngine.Vector3(-28,2,-28),new UnityEngine.Vector3(28,2,28)}:
            new[]{new UnityEngine.Vector3(-37,0,0),new UnityEngine.Vector3(37,0,0)};
        foreach(var point in points) if(!UnityEngine.AI.NavMesh.SamplePosition(point,out var hit,5f,UnityEngine.AI.NavMesh.AllAreas))
            throw new System.Exception("Spawn is outside navigation: "+point);
        if(!UnityEngine.AI.NavMesh.SamplePosition(points[0],out var from,5f,-1) ||
           !UnityEngine.AI.NavMesh.SamplePosition(points[1],out var to,5f,-1)) throw new System.Exception("Missing lane endpoint");
        var lane=new UnityEngine.AI.NavMeshPath();
        if(!UnityEngine.AI.NavMesh.CalculatePath(from.position,to.position,-1,lane) || lane.status!=UnityEngine.AI.NavMeshPathStatus.PathComplete)
            throw new System.Exception("Disconnected main lane: "+sceneName);
        report.AppendLine(sceneName+": original vertices="+verts.Count+", triangles="+triangles.Count/3+", baked triangles="+triangulation.indices.Length/3+", lane=complete");
    } finally { instance.Remove();UnityEngine.Object.DestroyImmediate(mesh); }
    UnityEditor.AssetDatabase.TryGetGUIDAndLocalFileIdentifier(data,out string guid,out long fileId);
    yaml=yaml.Replace(oldRef.Value,"m_NavMeshData: {fileID: "+fileId+", guid: "+guid+", type: 2}");
    System.IO.File.WriteAllText(scenePath,yaml);
}
UnityEditor.AssetDatabase.SaveAssets();UnityEditor.AssetDatabase.Refresh();
return report.ToString();
