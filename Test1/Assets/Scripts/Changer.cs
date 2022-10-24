using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public bool change = false;
    private void OnCollisionEnter(Collision collision)
    {
        change = true;
    }
}
