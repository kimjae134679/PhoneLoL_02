Shader "Mobile/Unlit (Supports Lightmap)"
{
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        [HideInInspector] _PhoneLOLLightmap ("Original mobile lightmap", 2D) = "white" {}
        [HideInInspector] _PhoneLOLHasLightmap ("Original lightmap enabled", Float) = 0
        [HideInInspector] _PhoneLOLLightmapST ("Original lightmap transform", Vector) = (1,1,0,0)
    }
    SubShader {
        Tags { "RenderType"="Opaque" "Queue"="Geometry" }
        Pass {
            ZWrite On
            Cull Back
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            sampler2D _MainTex, _PhoneLOLLightmap;
            float4 _MainTex_ST, _PhoneLOLLightmapST;
            float _PhoneLOLHasLightmap;
            struct Input { float4 vertex:POSITION; float2 uv:TEXCOORD0; float2 uv2:TEXCOORD1; };
            struct Output { float4 vertex:SV_POSITION; float2 uv:TEXCOORD0; float2 lightUV:TEXCOORD1; };
            Output vert(Input v) {
                Output o;o.vertex=UnityObjectToClipPos(v.vertex);
                o.uv=TRANSFORM_TEX(v.uv,_MainTex);
                o.lightUV=v.uv2*_PhoneLOLLightmapST.xy+_PhoneLOLLightmapST.zw;
                return o;
            }
            float4 frag(Output i):SV_Target {
                float4 color=tex2D(_MainTex,i.uv);
                float4 lm=tex2D(_PhoneLOLLightmap,i.lightUV);
                // The APK uses opaque ETC1 double-LDR maps and the VertexLM pass.
                color.rgb*=lerp(float3(1,1,1),lm.rgb*2.0,_PhoneLOLHasLightmap);
                return color;
            }
            ENDHLSL
        }
    }
}
