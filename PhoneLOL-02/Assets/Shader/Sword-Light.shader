Shader "Custom/Sword-Light" {
Properties {
 _node_2 ("node_2", 2D) = "white" {}
 _node_7 ("node_7", Color) = (0.5,1,0.5,1)
}
// Stable APK GLSL source SHA256: 470c393573e1e66a4fd132110c4f96a37d124ee3aa3ddf92d5f7c1044e2c95c5
SubShader { Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
Pass { Tags { "LightMode"="ForwardBase" }
Cull Back
ZWrite Off
Blend One One

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
    o.worldNormal = mul(normalize(v.normal), (float3x3)unity_WorldToObject);
    return o;
}
float4 frag(v2f i) : SV_Target {
float t = (_Time + _TimeEditor).y;
float3 sampled = tex2D(_node_2, (i.uv + t * float2(-1, 0)) * _node_2_ST.xy + _node_2_ST.zw).rgb;
float facing = dot(i.worldNormal, normalize(_WorldSpaceCameraPos - i.worldPos));
return float4(sampled * _node_7.rgb * (facing * facing * facing * facing), 1);
}
ENDHLSL
}
}
}
