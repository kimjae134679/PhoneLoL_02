Shader "Custom/TristanaQWeapon" {
Properties {
 _MainTex ("MainTex", 2D) = "white" {}
 _Mask ("Mask", 2D) = "white" {}
[HideInInspector]  _Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}
// Stable APK GLSL source SHA256: a34b73af9455dc9f54490399b05f219edf9615dc3d618755ee0af57284e383ee
SubShader { Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
Pass { Tags { "LightMode"="ForwardBase" }
Cull Back
ZWrite Off
Blend SrcAlpha OneMinusSrcAlpha

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
float t = (_Time + _TimeEditor).y;
float4 sampled = tex2D(_MainTex, (i.uv + t * float2(0, 1)) * _MainTex_ST.xy + _MainTex_ST.zw);
float mask = tex2D(_Mask, i.uv * _Mask_ST.xy + _Mask_ST.zw).r;
return float4(sampled.rgb * 1.2, pow(sampled.r * mask, 5) * 0.8);
}
ENDHLSL
}
}
}
