"""Port NGUI shaders from the stable APK's GLES equations to Unity 6 HLSL.
The unclipped Colored/Gray variants use the same fragment equation without clipping.
Original programs and hashes are retained under Recovery/OriginalShaders.
"""
from pathlib import Path
import re
root=Path(__file__).resolve().parents[1]/"PhoneLOL-02"/"Assets"
count=0
for path in root.rglob("*.shader"):
    source=path.read_text(encoding="utf-8-sig")
    name=re.search(r'Shader "([^"]+)"',source)[1]
    if not (name.startswith("Unlit/") or name.startswith("Hidden/Unlit/")): continue
    if not any(x in name for x in ("Colored","Text","Packed")): continue
    clip=re.search(r" ([123])$",name)
    clips=int(clip[1]) if clip else 0
    premultiplied="Premultiplied" in name
    packed="Packed" in name
    text="/Text" in name
    gray="(Gray)" in name
    properties=source[source.index("Properties"):source.index("\t//Dummy")] if "//Dummy" in source else None
    if properties is None: continue
    shader='Shader "'+name+'" {\n'+properties+'\n'
    shader+='// Ported from the stable 1.15.11 GLES program; retains NGUI clipping uniforms.\n'
    shader+='SubShader {\n Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }\n'
    shader+=' Pass {\n ZWrite Off\n Cull Off\n Lighting Off\n'
    shader+=' Blend '+("One OneMinusSrcAlpha" if premultiplied else "SrcAlpha OneMinusSrcAlpha")+'\n'
    shader+=' HLSLPROGRAM\n #pragma vertex vert\n #pragma fragment frag\n #pragma target 3.0\n #include "UnityCG.cginc"\n'
    shader+=' sampler2D _MainTex;\n float _EffectAmount, _Intensity;\n'
    shader+=' float4 _ClipRange0, _ClipRange1, _ClipRange2, _ClipArgs0, _ClipArgs1, _ClipArgs2;\n'
    shader+=' struct appdata { float4 vertex : POSITION; float4 color : COLOR; float2 uv : TEXCOORD0; };\n'
    shader+=' struct v2f { float4 pos : SV_POSITION; float4 color : COLOR; float2 uv : TEXCOORD0;\n float2 clip0 : TEXCOORD1; float2 clip1 : TEXCOORD2; float2 clip2 : TEXCOORD3; };\n'
    shader+=' v2f vert(appdata v) {\n v2f o; o.pos = UnityObjectToClipPos(v.vertex); o.color = v.color; o.uv = v.uv;\n'
    shader+=' o.clip0 = v.vertex.xy * _ClipRange0.zw + _ClipRange0.xy;\n'
    for i in (1,2):
        shader+=f' o.clip{i} = float2(v.vertex.x * _ClipArgs{i}.w - v.vertex.y * _ClipArgs{i}.z, v.vertex.x * _ClipArgs{i}.z + v.vertex.y * _ClipArgs{i}.w) * _ClipRange{i}.zw + _ClipRange{i}.xy;\n'
    shader+=' return o;\n }\n float4 frag(v2f i) : SV_Target {\n float4 sampled = tex2D(_MainTex, i.uv);\n'
    if packed:
        shader+=' float4 channels = saturate(ceil(i.color - 0.5));\n float4 tint = saturate((channels * 0.51 - i.color) / -0.49);\n float4 col = float4(tint.rgb, tint.a * dot(sampled, channels));\n'
    elif text:
        shader+=' float4 col = float4(i.color.rgb, i.color.a * sampled.a);\n'
    else:
        shader+=' float4 col = sampled * i.color;\n'
    if gray:
        shader+=' col.rgb = lerp(col.rgb, dot(col.rgb, float3(0.3, 0.59, 0.11)).xxx, _EffectAmount) * _Intensity;\n'
    if clips:
        shader+=' float fade = 1;\n'
        for i in range(clips):
            shader+=f' float2 edge{i} = (1 - abs(i.clip{i})) * _ClipArgs{i}.xy;\n fade = min(fade, min(edge{i}.x, edge{i}.y));\n'
        shader+=' fade = saturate(fade);\n col.a *= fade;\n'
        if premultiplied:shader+=' col.rgb *= fade;\n'
    shader+=' return col;\n }\n ENDHLSL\n }\n}\n}\n'
    path.write_text(shader,encoding="utf-8")
    count+=1
print("NGUI shader ports:",count)
