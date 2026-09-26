"""Port the remaining original fixed-function particle passes to GLES3 HLSL."""
from pathlib import Path
import re
r=Path(__file__).resolve().parents[1]
a=r/"PhoneLOL-02/Assets"
shader_rules={
"Particles/Additive":("SrcAlpha One","2.0 * i.color * _TintColor * tex2D(_MainTex, i.uv)"),
"Mobile/Particles/Additive":("SrcAlpha One","i.color * tex2D(_MainTex, i.uv)"),
"Mobile/Particles/Alpha Blended":("SrcAlpha OneMinusSrcAlpha","i.color * tex2D(_MainTex, i.uv)"),
"FXMaker/Mask Additive":("SrcAlpha One","i.color * tex2D(_MainTex, i.uv) * tex2D(_Mask, i.maskUV)"),
"FXMaker/Mask Additive Tint":("SrcAlpha One","2.0 * i.color * _TintColor * tex2D(_MainTex, i.uv) * tex2D(_Mask, i.maskUV)")}
for p in (a/"Shader").glob("*.shader"):
    s=p.read_text(encoding="utf-8-sig");name=re.search(r'Shader "([^"]+)"',s)[1]
    if name not in shader_rules:continue
    props=re.search(r"Properties\s*\{.*?\n\}",s,re.S)[0]
    blend,formula=shader_rules[name]
    out='Shader "'+name+'" {\n'+props+'\n'
    out+='// Preserve the original fixed-function texture and blend equations on GLES3.\n'
    out+='SubShader { Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }\nPass { ZWrite Off Cull Off Lighting Off\nBlend '+blend+'\n'
    out+="""HLSLPROGRAM
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
float4 frag(v2f i):SV_Target { return """+formula+"""; }
ENDHLSL
}
}
}
"""
    p.write_text(out,encoding="utf-8")
