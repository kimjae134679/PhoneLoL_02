Shader "Custom/Yasuo_3_W_Smoke" {
Properties {
 _smoke ("smoke", 2D) = "white" {}
 _mask ("mask", 2D) = "white" {}
 _smoke2 ("smoke2", 2D) = "white" {}
[HideInInspector]  _Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}
	//DummyShaderTextExporter
	
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Lambert
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutput o)
		{
			float4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}