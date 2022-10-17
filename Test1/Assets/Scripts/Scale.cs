using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallsX") || collision.gameObject.CompareTag("WallsZ"))
        {
            ChangeScale();
        }
    }
    void ChangeScale()
    {
        float rndScale = Random.Range(0.5f, 3f);
        transform.localScale = new Vector3(rndScale, rndScale, rndScale);
    }
}
