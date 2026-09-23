Shader "ProjectT/MapTransperant" {
Properties {
    _MainTex ("MainTex", 2D) = "white" {}
    _Color ("Color", Color) = (1,1,1,1)
}
SubShader {
    Tags { "Queue"="Transparent" "RenderType"="Transparent" }
    Pass {
        Cull Back
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha
        HLSLPROGRAM
        #pragma vertex vert
        #pragma fragment frag
        #include "UnityCG.cginc"
        // Port of the stable APK GLES equation, source SHA-256 prefix 80fb83eb8d98.
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
            return sampled * _Color;
        }
        ENDHLSL
    }
}
