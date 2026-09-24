Shader "Custom/FizzW_MarkerL" {
Properties {
 _TintColor ("Tint Color", Color) = (0.5,0.5,0.5,1)
 _MainTex ("Particle Texture", 2D) = "white" {}
 _MaskTex ("Mask Texture", 2D) = "white" {}
 _MaskClip ("Mask Clip", Range(0,1)) = 0.5
}
// Stable APK GLSL source SHA256: 91b75650041742d538939dd7bf009f5f611941fb9b7ef70282cfd7e8e7ca91a7
SubShader { Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
Pass { Tags { "LightMode"="ForwardBase" }
Cull Off
ZWrite Off
Blend SrcAlpha One

HLSLPROGRAM
#pragma vertex vert
#pragma fragment frag
#pragma target 3.0
#include "UnityCG.cginc"
#include "Lighting.cginc"
sampler2D _MainTex, _Mask, _MaskTex, _node_2, _smoke, _smoke2, _mask;
float4 _MainTex_ST, _Mask_ST, _MaskTex_ST, _node_2_ST, _smoke_ST, _smoke2_ST, _mask_ST;
float4 _TintColor, _Color, _node_7, _TimeEditor;
float _MaskClip;
struct appdata { float4 vertex : POSITION; float3 normal : NORMAL; float4 color : COLOR; float2 uv : TEXCOORD0; };
struct v2f { float4 pos : SV_POSITION; float4 color : COLOR; float2 uv : TEXCOORD0;
float3 worldPos : TEXCOORD1; float3 worldNormal : TEXCOORD2; };
v2f vert(appdata v) {
    v2f o; o.pos = UnityObjectToClipPos(v.vertex); o.color = v.color; o.uv = v.uv;
    o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
    // Normalize after inverse-transpose so scaled character meshes do not overexpose.
    o.worldNormal = UnityObjectToWorldNormal(v.normal);
    return o;
}
float4 frag(v2f i) : SV_Target {
float2 uv = i.uv * _MainTex_ST.xy + _MainTex_ST.zw;
float2 maskUV = i.uv + (1 - float2(0, _MaskClip)) * _MaskTex_ST.xy + _MaskTex_ST.zw;
return 2 * i.color * _TintColor * tex2D(_MainTex, uv) * tex2D(_MaskTex, maskUV);
}
ENDHLSL
}
}
}
