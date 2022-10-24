using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : Changer
{
    private void Update()
    {
        if (change)
        {
            ChangeScale();
        }
        change = false;
    }
    void ChangeScale()
    {
        float rndScale = Random.Range(0.5f, 3f);
        transform.localScale = new Vector3(rndScale, rndScale, rndScale);
    }
}
