Shader "ProjectT/DiffuseOpaque" {
Properties {
 _MainTex ("MainTex", 2D) = "white" {}
 _Color ("Color", Color) = (1,1,1,1)
[HideInInspector]  _Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}
// Stable APK GLSL source SHA256: a70959cad169c5aebba7e0eb361f4cf119aef291d26ddc00c53e2f8a91193887
SubShader { Tags { "Queue"="AlphaTest" "RenderType"="TransparentCutout" }
Pass { Tags { "LightMode"="ForwardBase" }
Cull Back

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
float4 sampled = tex2D(_MainTex, i.uv * _MainTex_ST.xy + _MainTex_ST.zw);
clip(sampled.a - 0.5);
float diffuse = max(0, dot(i.worldNormal, normalize(_WorldSpaceLightPos0.xyz)));
float rim = pow(1 - max(0, dot(i.worldNormal, normalize(_WorldSpaceCameraPos - i.worldPos))), 3);
// Unity upgrades legacy light intensities by two; do not multiply them again.
float3 rgb = (0.5 * sampled.rgb + sampled.rgb * diffuse * _LightColor0.rgb + float3(0.3, 0.3, 0.4) * rim) * _Color.rgb;
return float4(rgb, 1);
}
ENDHLSL
}
}
}
