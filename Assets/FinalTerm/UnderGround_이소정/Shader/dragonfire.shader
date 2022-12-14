Shader "Custom/dragonfire"
{

    Properties

    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _MainTex2("Albedo (RGB)", 2D) = "white" {}
    }

        SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent"}
        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows alpha:fade
        #pragma target 3.0
        sampler2D _MainTex;
        sampler2D _MainTex2;
        struct Input

        {
            float2 uv_MainTex;

            float2 uv_MainTex2;
        };
        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex.x,IN.uv_MainTex.y - _Time.y)); //수직으로 올라가게
            o.Albedo = c.rgb;
            //o.Emission = float3(IN.uv_MainTex.x, IN.uv_MainTex.y, 0); //조명
            o.Emission = c.rgb * d.rgb; // 곱하기 하면 밝은 부분은 더 밝아지고 어두운 부분 더 어두움
            o.Alpha = c.a * d.a;
        }

        ENDCG
    }
        FallBack "Diffuse"

}