using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject[] prefabs;
       
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rnd = Random.Range(0, prefabs.Length);            
            Instantiate(prefabs[rnd], transform.position, Quaternion.identity);                    
        }        
    }    
}
