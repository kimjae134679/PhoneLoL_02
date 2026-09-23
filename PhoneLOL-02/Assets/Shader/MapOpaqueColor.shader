Shader "ProjectT/MapOpaqueColor" {
Properties {
    _MainTex ("MainTex", 2D) = "white" {}
    _Color ("Color", Color) = (0.5,0.5,0.5,1)
}
SubShader {
    Tags { "Queue"="Geometry" "RenderType"="Opaque" }
    Pass {
        Cull Back
        ZWrite On
        HLSLPROGRAM
        #pragma vertex vert
        #pragma fragment frag
        #include "UnityCG.cginc"
        // Port of the stable APK GLES equation, source SHA-256 prefix 4d757bb9ffc1.
        sampler2D _MainTex;
        float4 _MainTex_ST, _Color;
        struct Attributes { float4 position : POSITION; float2 uv : TEXCOORD0; };
        struct Varyings { float4 position : SV_POSITION; float2 uv : TEXCOORD0; };
        Varyings vert(Attributes input) {
            Varyings output;
            output.position = UnityObjectToClipPos(input.position);
            output.uv = TRANSFORM_TEX(input.uv, _MainTex);
            return output;
        }
        float4 frag(Varyings input) : SV_Target {
            float4 sampled = tex2D(_MainTex, input.uv);
            return float4(2.0 * _Color.rgb * sampled.rgb, 1.0);
        }
        ENDHLSL
    }
}
