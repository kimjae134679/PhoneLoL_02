var output = new System.Text.StringBuilder();
foreach (string name in new[] { "MapOpaqueColor", "MapTransperant" }) {
    var shader = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Shader>("Assets/Shader/" + name + ".shader");
    if (shader == null || UnityEditor.ShaderUtil.ShaderHasError(shader))
        throw new System.Exception("Map shader import failed: " + name);
}
foreach (var item in new[] { new { path="turret/Turret0", id=30000 }, new { path="monster/Dragon", id=20002 } }) {
    var prefab=UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.GameObject>("Assets/Resources/"+item.path+".prefab");
    var actor=prefab.GetComponent<Actor>();
    if(actor==null || actor.m_hero_id!=item.id)
        throw new System.Exception("Original Actor identity missing: "+item.path);
    output.AppendLine(item.path+" hero="+actor.m_hero_id+" selfCreate="+actor.m_selfCreateHeroInfo);
}
foreach(var item in new[] { new { name="MultiGame", count=296 }, new { name="MtmGame", count=636 } }) {
    var scene=UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scenes/"+item.name+".unity",UnityEditor.SceneManagement.OpenSceneMode.Additive);
    try {
        int count=0;
        foreach(var root in scene.GetRootGameObjects()) foreach(var renderer in root.GetComponentsInChildren<UnityEngine.MeshRenderer>(true)) {
            var filter=renderer.GetComponent<UnityEngine.MeshFilter>();
            if(filter==null || filter.sharedMesh==null) continue;
            string path=UnityEditor.AssetDatabase.GetAssetPath(filter.sharedMesh);
            if(!path.StartsWith("Assets/Mesh/RecoveredStaticBatches/")) continue;
            if(filter.sharedMesh.subMeshCount!=renderer.sharedMaterials.Length)
                throw new System.Exception("Recovered material/submesh mismatch: "+renderer.name);
            count++;
        }
        if(count!=item.count) throw new System.Exception("Missing recovered meshes: "+item.name+" "+count);
        output.AppendLine(item.name+" recovered="+count);
    } finally { UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,true); }
}
return output.ToString();
