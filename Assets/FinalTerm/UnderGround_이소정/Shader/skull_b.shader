Shader "Custom/skull_b"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }

        CGPROGRAM
        #pragma surface surf MyCustom noambient

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingMyCustom(SurfaceOutput s, float3 lightDir, float atten) {
            // dot operation with Normal and lightDir
            float ndotl = dot(s.Normal, lightDir);

            // removes values under 0
            ndotl = saturate(ndotl);

            // lighten 
            ndotl = saturate(ndotl) + 0.05;

            return ndotl;
        }
        ENDCG
    }
        FallBack "Diffuse"
}