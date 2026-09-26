Shader "Hidden/TerrainEngine/Splatmap/Lightmap-AddPass" {
Properties {
 _Control ("Control (RGBA)", 2D) = "black" {}
 _Splat3 ("Layer 3 (A)", 2D) = "white" {}
 _Splat2 ("Layer 2 (B)", 2D) = "white" {}
 _Splat1 ("Layer 1 (G)", 2D) = "white" {}
 _Splat0 ("Layer 0 (R)", 2D) = "white" {}
}
SubShader { Tags { "Queue"="Geometry-99" "RenderType"="Opaque" "IgnoreProjector"="True" "TerrainCompatible"="True" }
CGPROGRAM
#pragma target 3.0
#pragma surface surf Lambert vertex:SplatmapVert finalcolor:SplatmapFinalColor decal:add addshadow fullforwardshadows
#pragma multi_compile_instancing
#pragma instancing_options assumeuniformscaling nomatrices nolightprobe nolightmap forwardadd
#pragma shader_feature_local _ALPHATEST_ON
#define TERRAIN_SPLAT_ADDPASS
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
Fallback "Diffuse"
}
