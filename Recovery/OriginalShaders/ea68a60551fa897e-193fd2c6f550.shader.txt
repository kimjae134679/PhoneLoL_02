Shader "FXMaker/Mask Additive" {
Properties {
 _MainTex ("Particle Texture", 2D) = "white" {}
 _Mask ("Mask", 2D) = "white" {}
}
SubShader { 
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  BindChannels {
   Bind "vertex", Vertex
   Bind "color", Color
   Bind "texcoord", TexCoord
  }
  ZWrite Off
  Cull Off
  Fog {
   Color (0,0,0,0)
  }
  Blend SrcAlpha One
  SetTexture [_Mask] { combine texture * primary }
  SetTexture [_MainTex] { combine texture * previous }
 }
}
}