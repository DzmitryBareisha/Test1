using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private MeshFilter shapeChange;
    [SerializeField] private Mesh[] shapeUse;
    private int currentShape;
    
    void Start()
    {
        shapeChange = GetComponent<MeshFilter>();
    }
    private void OnCollisionEnter(Collision collision)
    {       
        ChangeShape();
    }

    void ChangeShape()
    {
        currentShape = Random.Range(0, shapeUse.Length);
        shapeChange.mesh = shapeUse[currentShape];
    }
}
