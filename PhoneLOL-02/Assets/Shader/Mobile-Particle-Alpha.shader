Shader "Mobile/Particles/Alpha Blended" {
Properties {
 _MainTex ("Particle Texture", 2D) = "white" {}
}
// Preserve the original fixed-function texture and blend equations on GLES3.
SubShader { Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
Pass { ZWrite Off Cull Off Lighting Off
Blend SrcAlpha OneMinusSrcAlpha
HLSLPROGRAM
#pragma vertex vert
#pragma fragment frag
#pragma target 3.0
#include "UnityCG.cginc"
sampler2D _MainTex, _Mask;
float4 _MainTex_ST, _Mask_ST, _TintColor;
struct appdata { float4 vertex:POSITION; float4 color:COLOR; float2 uv:TEXCOORD0; };
struct v2f { float4 vertex:SV_POSITION; float4 color:COLOR; float2 uv:TEXCOORD0; float2 maskUV:TEXCOORD1; };
v2f vert(appdata v) {
    v2f o; o.vertex=UnityObjectToClipPos(v.vertex); o.color=v.color;
    o.uv=TRANSFORM_TEX(v.uv,_MainTex); o.maskUV=TRANSFORM_TEX(v.uv,_Mask); return o;
}
float4 frag(v2f i):SV_Target { return i.color * tex2D(_MainTex, i.uv); }
ENDHLSL
}
}
}
