// Recover each Unity 4 static-batch subset into the renderer's local coordinates.
var changes = new System.Collections.Generic.List<string>();
int recovered = 0;
foreach (string path in System.IO.Directory.GetFiles("Assets/Scenes","*.unity")) {
    string yaml = System.IO.File.ReadAllText(path);
    var subsets = new System.Collections.Generic.Dictionary<ulong,int[]>();
    foreach(System.Text.RegularExpressions.Match block in System.Text.RegularExpressions.Regex.Matches(yaml,@"(?ms)^--- !u!23 &(\d+)\r?\n(.*?)(?=^---|\z)")) {
        var m=System.Text.RegularExpressions.Regex.Match(block.Groups[2].Value,@"m_SubsetIndices: ([0-9a-fA-F]+)");
        if(!m.Success) continue;
        string hex=m.Groups[1].Value; var ids=new int[hex.Length/8];
        for(int i=0;i<ids.Length;i++) { var b=new byte[4]; for(int j=0;j<4;j++) b[j]=System.Convert.ToByte(hex.Substring(i*8+j*2,2),16); ids[i]=System.BitConverter.ToInt32(b,0); }
        subsets.Add(ulong.Parse(block.Groups[1].Value),ids);
    }
    if(subsets.Count==0) continue;
    string folder="Assets/Mesh/RecoveredStaticBatches";
    System.IO.Directory.CreateDirectory(folder); UnityEditor.AssetDatabase.Refresh();
    var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene(path,UnityEditor.SceneManagement.OpenSceneMode.Additive);
    int count=0;
    try {
        foreach(var root in scene.GetRootGameObjects()) foreach(var renderer in root.GetComponentsInChildren<UnityEngine.MeshRenderer>(true)) {
            ulong id=UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(renderer).targetObjectId;
            if(!subsets.TryGetValue(id,out int[] indices)) continue;
            var filter=renderer.GetComponent<UnityEngine.MeshFilter>();
            if(filter==null || filter.sharedMesh==null) throw new System.Exception("Missing batch mesh "+id);
            var input=filter.sharedMesh;
            if(indices.Length!=renderer.sharedMaterials.Length) throw new System.Exception("Material/subset count mismatch "+id);
            var combine=new UnityEngine.CombineInstance[indices.Length];
            for(int i=0;i<indices.Length;i++) combine[i]=new UnityEngine.CombineInstance { mesh=input,subMeshIndex=indices[i],transform=renderer.transform.worldToLocalMatrix };
            var mesh=new UnityEngine.Mesh { name=renderer.name+" recovered" }; mesh.CombineMeshes(combine,false,true,false); mesh.RecalculateBounds();
            if(mesh.vertexCount==0) throw new System.Exception("Empty recovered mesh "+id);
            string output=folder+"/"+System.IO.Path.GetFileNameWithoutExtension(path)+"-"+id+".asset";
            if(UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Mesh>(output)!=null) throw new System.Exception("Recovery already exists: "+output);
            UnityEditor.AssetDatabase.CreateAsset(mesh,output);
            ulong filterId=UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(filter).targetObjectId;
            changes.Add(path.Replace('\\','/')+"|"+filterId+"|"+id+"|"+UnityEditor.AssetDatabase.AssetPathToGUID(output));
            count++;
        }
        if(count!=subsets.Count) throw new System.Exception("Unmatched static renderers "+path+" "+count+"/"+subsets.Count);
        recovered+=count;
    } finally { UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true); }
}
UnityEditor.AssetDatabase.SaveAssets();
string recordPath=System.IO.Path.GetFullPath(System.IO.Path.Combine(UnityEngine.Application.dataPath,"../../Recovery/StaticBatchReplacements.txt"));
System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(recordPath));
System.IO.File.WriteAllLines(recordPath,changes);
return "Recovered static renderers="+recovered;
