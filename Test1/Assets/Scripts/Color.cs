using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : Changer
{
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (change)
        {
            ChangeColor();
        }
        change = false;        
    }        
    void ChangeColor()
    {       
            meshRenderer.material.color = Random.ColorHSV();             
    }
}
