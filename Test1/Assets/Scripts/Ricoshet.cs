using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricoshet : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 direction;
    public float speed = 5f;
    private int moveX;
    private int moveZ;  
    private void Start()
    {        
        rb = GetComponent<Rigidbody>();
        moveX = Random.Range(-1, 2);
        moveZ = Random.Range(-1, 2);
        if (moveX == 0 && moveZ == 0)
        {
            direction = new Vector3(Random.Range(-1, 2) > 0 ? 1 : -1, direction.y, Random.Range(-1, 2));            
        }
        else
        {
            direction = new Vector3(moveX, direction.y, moveZ);
        }
    }
    private void Update()
    {
        rb.velocity = direction * speed;
    }    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallsX"))
        {
            direction.x = -direction.x;            
        }
        if (collision.gameObject.CompareTag("WallsZ"))
        {
            direction.z = -direction.z;            
        }         
    }   
}
