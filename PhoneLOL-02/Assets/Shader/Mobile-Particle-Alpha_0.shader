Shader "Mobile/Particles/Alpha Blended Color" {
Properties {
 _TintColor ("Tint Color", Color) = (0.5,0.5,0.5,1)
 _MainTex ("Particle Texture", 2D) = "white" {}
}
// Stable GLES source SHA256: b7a13438050fa580ba5e0b6d6cd5d5d7a8346b90d1e1f38dc1332de45cfc567e
SubShader { Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
Pass { ZWrite Off Cull Off Lighting Off
Blend SrcAlpha OneMinusSrcAlpha

 HLSLPROGRAM
 #pragma vertex vert
 #pragma fragment frag
 #pragma target 3.0
 #include "UnityCG.cginc"
 sampler2D _MainTex;
 float4 _MainTex_ST, _TintColor;
 struct appdata { float4 vertex : POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; };
 struct v2f { float4 pos : SV_POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; };
 v2f vert(appdata v) {
     v2f o; o.pos = UnityObjectToClipPos(v.vertex); o.color = v.color;
     o.uv = TRANSFORM_TEX(v.uv, _MainTex); return o;
 }
 float4 frag(v2f i) : SV_Target {
 return 2 * i.color * _TintColor * tex2D(_MainTex, i.uv);
}
ENDHLSL
}
}
}
