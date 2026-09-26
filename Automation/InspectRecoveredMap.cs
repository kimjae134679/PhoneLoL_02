var scene = UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/MultiGame.unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
var result = new System.Text.StringBuilder();
try {
    int count=0;
    foreach (var root in scene.GetRootGameObjects()) foreach (var r in root.GetComponentsInChildren<UnityEngine.MeshRenderer>(true)) {
        if(count>=3) continue;
        var f=r.GetComponent<UnityEngine.MeshFilter>(); if(f==null || f.sharedMesh==null || f.sharedMesh.subMeshCount<10) continue;
        var mesh=f.sharedMesh;
        result.AppendLine("id="+UnityEditor.GlobalObjectId.GetGlobalObjectIdSlow(r).targetObjectId+" name="+r.name+" pos="+r.transform.position+" scale="+r.transform.lossyScale+" mesh="+mesh.name+" submeshes="+mesh.subMeshCount+" static="+r.isPartOfStaticBatch+" bounds="+mesh.bounds);
        if(mesh.subMeshCount>36) result.AppendLine("sub36="+mesh.GetSubMesh(36).bounds+" materials="+r.sharedMaterials.Length);
        if(++count==3) break;
    }
} finally { UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true); }
var catalog=GameServer.KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE();
result.AppendLine("Catalog count="+catalog.EPEJNKKPCCG().Count);
foreach(ushort id in new ushort[]{1,2,10,100,200}) {var info=new GameServer.NEFBHKKAMJF();bool found=info.FIGLEPBIEEJ(id);result.AppendLine("Hero="+id+" found="+found+" definition="+(info.GPNKIAHCKMG!=null));}
return result.ToString();
