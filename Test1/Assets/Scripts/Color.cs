using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private MeshRenderer meshRenderer;
   
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }     
    private void OnCollisionEnter(Collision collision)
    {        
        ChangeColor();               
    }
    void ChangeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
