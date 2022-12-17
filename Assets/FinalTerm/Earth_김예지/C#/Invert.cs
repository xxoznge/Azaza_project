using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invert : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;

    public bool InvertEffect;

    void Start()
    {
        myShader = Shader.Find("Earth/Invert");    // image effect shader file must have been created
        myMaterial = new Material(myShader);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }
}
