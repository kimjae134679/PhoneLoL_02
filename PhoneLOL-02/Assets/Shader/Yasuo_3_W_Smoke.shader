Shader "Custom/Yasuo_3_W_Smoke" {
Properties {
 _smoke ("smoke", 2D) = "white" {}
 _mask ("mask", 2D) = "white" {}
 _smoke2 ("smoke2", 2D) = "white" {}
[HideInInspector]  _Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}
// Stable APK GLSL source SHA256: f25d768508ed50744c65593624a2b04bc3c4b6028c4fc51625357f5d66aef1b5
SubShader { Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
Pass { Tags { "LightMode"="ForwardBase" }
Cull Off
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
float a = tex2D(_smoke, (i.uv * float2(1.5, 1) + t * float2(0.1, -2.6)) * _smoke_ST.xy + _smoke_ST.zw).a;
float b = tex2D(_smoke2, (i.uv + t * float2(-0.1, -2.1)) * _smoke2_ST.xy + _smoke2_ST.zw).a;
float mask = tex2D(_mask, i.uv * _mask_ST.xy + _mask_ST.zw).a;
return float4(0, 0, 0, (a + b) * mask);
}
ENDHLSL
}
}
}
