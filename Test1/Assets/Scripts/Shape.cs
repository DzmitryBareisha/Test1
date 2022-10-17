using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private MeshFilter shapeChange;
    [SerializeField] private Mesh[] shapeUse;
    private int currentShape;
    // Start is called before the first frame update
    void Start()
    {
        shapeChange = GetComponent<MeshFilter>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallsX") || collision.gameObject.CompareTag("WallsZ"))
        {
            ChangeShape();
        }
    }

    void ChangeShape()
    {
        currentShape = Random.Range(0, shapeUse.Length);
        shapeChange.mesh = shapeUse[currentShape];
    }
}
