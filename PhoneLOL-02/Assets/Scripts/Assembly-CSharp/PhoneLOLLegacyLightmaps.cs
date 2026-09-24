using System;
using UnityEngine;

// Unity 6 does not deserialize Unity 4's baked lighting scene records.
[DefaultExecutionOrder(-32000)]
public sealed class PhoneLOLLegacyLightmaps : MonoBehaviour
{
    [Serializable] public sealed class Binding
    {
        public Renderer renderer;
        public Terrain terrain;
        public int index;
        public Vector4 scaleOffset;
    }
    public Texture2D[] maps;
    public Binding[] bindings;
    private void Awake() { Apply(); }
    public void Apply()
    {
        var data = new LightmapData[maps.Length];
        for (int i=0;i<maps.Length;i++) {
            if(maps[i]==null) throw new InvalidOperationException("Missing original lightmap "+i);
            data[i]=new LightmapData { lightmapColor=maps[i] };
        }
        LightmapSettings.lightmapsMode=LightmapsMode.NonDirectional;
        LightmapSettings.lightmaps=data;
        foreach(var b in bindings) {
            if(b.index<0 || b.index>=maps.Length) throw new InvalidOperationException("Invalid original lightmap index");
            if(b.renderer!=null) {
                b.renderer.lightmapIndex=b.index;
                b.renderer.lightmapScaleOffset=b.scaleOffset;
                var block=new MaterialPropertyBlock();
                b.renderer.GetPropertyBlock(block);
                block.SetTexture("_PhoneLOLLightmap",maps[b.index]);
                block.SetVector("_PhoneLOLLightmapST",b.scaleOffset);
                block.SetFloat("_PhoneLOLHasLightmap",1f);
                b.renderer.SetPropertyBlock(block);
            }
            if(b.terrain!=null) {
                b.terrain.lightmapIndex=b.index;
                b.terrain.lightmapScaleOffset=b.scaleOffset;
            }
        }
        Debug.Log("V1169_LIGHTMAPS|scene="+gameObject.scene.name+"|maps="+maps.Length+"|bindings="+bindings.Length);
    }
}
