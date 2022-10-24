using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : Changer
{
    private MeshFilter shapeChange;
    [SerializeField] private Mesh[] shapeUse;
    private int currentShape;
    
    void Start()
    {
        shapeChange = GetComponent<MeshFilter>();
    }
    private void Update()
    {
        if (change)
        {
            ChangeShape();
        }
        change = false;
    }

    void ChangeShape()
    {
        currentShape = Random.Range(0, shapeUse.Length);
        shapeChange.mesh = shapeUse[currentShape];
    }
}
