Shader "Particles/~Additive-Multiply" {
Properties {
 _TintColor ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
 _MainTex ("Particle Texture", 2D) = "white" {}
 _InvFade ("Soft Particles Factor", Range(0.01,3)) = 1
}
// Stable GLES source SHA256: 03e75385b395f3066d589655a0bad4f96198ef76d9d28300ed56d9b6914e4336
SubShader { Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
Pass { ZWrite Off Cull Off Lighting Off
Blend One OneMinusSrcAlpha

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
 float4 t = tex2D(_MainTex, i.uv); return float4(_TintColor.rgb * t.rgb * i.color.rgb * 2, (1 - t.a) * _TintColor.a * i.color.a * 2);
}
ENDHLSL
}
}
}
