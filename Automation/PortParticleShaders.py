"""Restore supported particle shaders from stable GLES blend and color equations."""
from pathlib import Path
import json,re
r=Path(__file__).resolve().parents[1]
idx=json.loads((r/"Recovery/OriginalShaders/index.json").read_text(encoding="utf-8"))
formulas={
"Mobile/Particles/Additive Color":"return 2 * i.color * _TintColor * tex2D(_MainTex, i.uv);",
"Mobile/Particles/Alpha Blended Color":"return 2 * i.color * _TintColor * tex2D(_MainTex, i.uv);",
"Particles/Alpha Blended":"return 2 * i.color * _TintColor * tex2D(_MainTex, i.uv);",
"Particles/~Additive-Multiply":"float4 t = tex2D(_MainTex, i.uv); return float4(_TintColor.rgb * t.rgb * i.color.rgb * 2, (1 - t.a) * _TintColor.a * i.color.a * 2);",
"Particles/Additive (Soft)":"float4 c = i.color * tex2D(_MainTex, i.uv); c.rgb *= c.a; return c;",
"Particles/Alpha Blended Premultiply":"return i.color * tex2D(_MainTex, i.uv) * i.color.a;"
}
count=0
for p in (r/"PhoneLOL-02/Assets").rglob("*.shader"):
 s=p.read_text(encoding="utf-8-sig");name=re.search(r'Shader "([^"]+)"',s)[1]
 if name not in formulas or "DummyShaderTextExporter" not in s:continue
 item=next(x for x in idx if x["name"]==name)
 original=(r/"Recovery/OriginalShaders"/item["file"]).read_text(encoding="utf-8")
 props=re.search(r"Properties\s*\{.*?\n\}",original,re.S)[0]
 blend=re.search(r"^\s*Blend ([^\n]+)",original,re.M)[1].strip()
 shader=f'Shader "{name}" {{\n{props}\n// Stable GLES source SHA256: {item["sha256"]}\n'
 shader+='SubShader { Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }\n'
 shader+='Pass { ZWrite Off Cull Off Lighting Off\nBlend '+blend+'\n'
 shader+="""
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
 """
 shader+=formulas[name]+"\n}\nENDHLSL\n}\n}\n}\n"
 p.write_text(shader,encoding="utf-8");count+=1
print("Particle shader ports:",count)
