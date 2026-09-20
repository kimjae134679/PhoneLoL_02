"""Port recovered character and skill shaders using their original GLES equations."""
from pathlib import Path
import re,json
repo=Path(__file__).resolve().parents[1]
evidence=repo/"Recovery/OriginalShaders"
index=json.loads((evidence/"index.json").read_text(encoding="utf-8"))
formulas={
"Custom/FizzW_MarkerL":"""float2 uv = i.uv * _MainTex_ST.xy + _MainTex_ST.zw;
float2 maskUV = i.uv + (1 - float2(0, _MaskClip)) * _MaskTex_ST.xy + _MaskTex_ST.zw;
return 2 * i.color * _TintColor * tex2D(_MainTex, uv) * tex2D(_MaskTex, maskUV);""",
"Custom/TristanaQWeapon":"""float t = (_Time + _TimeEditor).y;
float4 sampled = tex2D(_MainTex, (i.uv + t * float2(0, 1)) * _MainTex_ST.xy + _MainTex_ST.zw);
float mask = tex2D(_Mask, i.uv * _Mask_ST.xy + _Mask_ST.zw).r;
return float4(sampled.rgb * 1.2, pow(sampled.r * mask, 5) * 0.8);""",
"Custom/Sword-Light":"""float t = (_Time + _TimeEditor).y;
float3 sampled = tex2D(_node_2, (i.uv + t * float2(-1, 0)) * _node_2_ST.xy + _node_2_ST.zw).rgb;
float facing = dot(i.worldNormal, normalize(_WorldSpaceCameraPos - i.worldPos));
return float4(sampled * _node_7.rgb * (facing * facing * facing * facing), 1);""",
"Custom/Yasuo_3_W_Smoke":"""float t = (_Time + _TimeEditor).y;
float a = tex2D(_smoke, (i.uv * float2(1.5, 1) + t * float2(0.1, -2.6)) * _smoke_ST.xy + _smoke_ST.zw).a;
float b = tex2D(_smoke2, (i.uv + t * float2(-0.1, -2.1)) * _smoke2_ST.xy + _smoke2_ST.zw).a;
float mask = tex2D(_mask, i.uv * _mask_ST.xy + _mask_ST.zw).a;
return float4(0, 0, 0, (a + b) * mask);""",
"Custom/Yasuo_3_W_Wall":"""float t = (_Time + _TimeEditor).y;
float4 a = tex2D(_smoke, (i.uv * float2(2, 1) + t * float2(0.1, -2.4)) * _smoke_ST.xy + _smoke_ST.zw);
float4 b = tex2D(_smoke2, (i.uv + t * float2(-0.1, -3)) * _smoke2_ST.xy + _smoke2_ST.zw);
float mask = tex2D(_mask, i.uv * _mask_ST.xy + _mask_ST.zw).a;
return float4((a.rgb + b.rgb) * 2, (a.a + b.a) * mask);""",
"ProjectT/OnlyColor":"return _Color;"
}
lighting="""float4 sampled = tex2D(_MainTex, i.uv * _MainTex_ST.xy + _MainTex_ST.zw);
{cutout}
float diffuse = max(0, dot(i.worldNormal, normalize(_WorldSpaceLightPos0.xyz)));
float rim = pow(1 - max(0, dot(i.worldNormal, normalize(_WorldSpaceCameraPos - i.worldPos))), 3);
float3 rgb = (0.5 * sampled.rgb + sampled.rgb * diffuse * _LightColor0.rgb * 2 + float3(0.3, 0.3, 0.4) * rim) * _Color.rgb;
return float4(rgb, {alpha});"""
formulas["ProjectT/DiffuseOpaque"]=lighting.format(cutout="clip(sampled.a - 0.5);",alpha="1")
formulas["ProjectT/DiffuseTransparent"]=lighting.format(cutout="",alpha="sampled.a * _Color.a")
common="""
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
"""
count=0
for path in (repo/"PhoneLOL-02/Assets").rglob("*.shader"):
    s=path.read_text(encoding="utf-8-sig")
    name=re.search(r'Shader "([^"]+)"',s)[1]
    if name not in formulas or "DummyShaderTextExporter" not in s: continue
    item=next(x for x in index if x["name"]==name)
    original=(evidence/item["file"]).read_text(encoding="utf-8")
    properties=re.search(r"Properties\s*\{.*?\n\}",original,re.S)[0]
    opaque=name=="ProjectT/DiffuseOpaque"
    tags='"Queue"="AlphaTest" "RenderType"="TransparentCutout"' if opaque else '"Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True"'
    blend="One One" if name=="Custom/Sword-Light" else "SrcAlpha One" if name in ("Custom/FizzW_MarkerL","Custom/Yasuo_3_W_Wall") else "SrcAlpha OneMinusSrcAlpha"
    cull="Off" if name in ("Custom/FizzW_MarkerL","Custom/Yasuo_3_W_Smoke","Custom/Yasuo_3_W_Wall","ProjectT/OnlyColor") else "Back"
    states="Cull "+cull+"\n"+("" if opaque else "ZWrite Off\nBlend "+blend+"\n")
    result=f'Shader "{name}" {{\n{properties}\n// Stable APK GLSL source SHA256: {item["sha256"]}\n'
    result+=f'SubShader {{ Tags {{ {tags} }}\nPass {{ Tags {{ "LightMode"="ForwardBase" }}\n'+states+common+formulas[name]+"\n}\nENDHLSL\n}\n}\n}\n"
    path.write_text(result,encoding="utf-8");count+=1
print("Character and skill shader ports:",count)
