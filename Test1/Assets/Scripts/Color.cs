using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }     
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallsX") || collision.gameObject.CompareTag("WallsZ"))
        {
            ChangeColor();
        }        
    }
    void ChangeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
