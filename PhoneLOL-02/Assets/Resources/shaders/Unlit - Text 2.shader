Shader "Hidden/Unlit/Text 2" {
Properties {
 _MainTex ("Alpha (A)", 2D) = "white" {}
}

// Ported from the stable 1.15.11 GLES program; retains NGUI clipping uniforms.
SubShader {
 Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
 Pass {
 ZWrite Off
 Cull Off
 Lighting Off
 Blend SrcAlpha OneMinusSrcAlpha
 HLSLPROGRAM
 #pragma vertex vert
 #pragma fragment frag
 #pragma target 3.0
 #include "UnityCG.cginc"
 sampler2D _MainTex;
 float _EffectAmount, _Intensity;
 float4 _ClipRange0, _ClipRange1, _ClipRange2, _ClipArgs0, _ClipArgs1, _ClipArgs2;
 struct appdata { float4 vertex : POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; };
 struct v2f { float4 pos : SV_POSITION; float4 color : COLOR; float2 uv : TEXCOORD0;
 float2 clip0 : TEXCOORD1; float2 clip1 : TEXCOORD2; float2 clip2 : TEXCOORD3; };
 v2f vert(appdata v) {
 v2f o; o.pos = UnityObjectToClipPos(v.vertex); o.color = v.color; o.uv = v.uv;
 o.clip0 = v.vertex.xy * _ClipRange0.zw + _ClipRange0.xy;
 o.clip1 = float2(v.vertex.x * _ClipArgs1.w - v.vertex.y * _ClipArgs1.z, v.vertex.x * _ClipArgs1.z + v.vertex.y * _ClipArgs1.w) * _ClipRange1.zw + _ClipRange1.xy;
 o.clip2 = float2(v.vertex.x * _ClipArgs2.w - v.vertex.y * _ClipArgs2.z, v.vertex.x * _ClipArgs2.z + v.vertex.y * _ClipArgs2.w) * _ClipRange2.zw + _ClipRange2.xy;
 return o;
 }
 float4 frag(v2f i) : SV_Target {
 float4 sampled = tex2D(_MainTex, i.uv);
 float4 col = float4(i.color.rgb, i.color.a * sampled.a);
 float fade = 1;
 float2 edge0 = (1 - abs(i.clip0)) * _ClipArgs0.xy;
 fade = min(fade, min(edge0.x, edge0.y));
 float2 edge1 = (1 - abs(i.clip1)) * _ClipArgs1.xy;
 fade = min(fade, min(edge1.x, edge1.y));
 fade = saturate(fade);
 col.a *= fade;
 return col;
 }
 ENDHLSL
 }
}
}
