Shader "Nature/Terrain/Diffuse" {
Properties {
[HideInInspector]  _Control ("Control (RGBA)", 2D) = "red" {}
[HideInInspector]  _Splat3 ("Layer 3 (A)", 2D) = "white" {}
[HideInInspector]  _Splat2 ("Layer 2 (B)", 2D) = "white" {}
[HideInInspector]  _Splat1 ("Layer 1 (G)", 2D) = "white" {}
[HideInInspector]  _Splat0 ("Layer 0 (R)", 2D) = "white" {}
[HideInInspector]  _MainTex ("BaseMap (RGB)", 2D) = "white" {}
[HideInInspector]  _Color ("Main Color", Color) = (1,1,1,1)
}
SubShader { Tags { "Queue"="Geometry-100" "RenderType"="Opaque" "TerrainCompatible"="True" }
CGPROGRAM
#pragma target 3.0
#pragma surface surf Lambert vertex:SplatmapVert finalcolor:SplatmapFinalColor addshadow fullforwardshadows
#pragma multi_compile_instancing
#pragma instancing_options assumeuniformscaling nomatrices nolightprobe nolightmap forwardadd
#pragma shader_feature_local _ALPHATEST_ON
// Use the engine's terrain UV/weight handling with the original diffuse lighting model.
#include "UnityCG.cginc"
#include "TerrainSplatmapCommon.cginc"
void surf(Input IN, inout SurfaceOutput o) {
    half4 control;
    half weight;
    fixed4 diffuse;
    SplatmapMix(IN, control, weight, diffuse, o.Normal);
    o.Albedo=diffuse.rgb;
    o.Alpha=weight;
}
ENDCG
}
Dependency "AddPassShader" = "Hidden/TerrainEngine/Splatmap/Lightmap-AddPass"
Dependency "BaseMapShader" = "Hidden/TerrainEngine/Splatmap/Diffuse-Base"
Dependency "BaseMapGenShader" = "Hidden/TerrainEngine/Splatmap/Diffuse-BaseGen"
Fallback "Diffuse"
}
