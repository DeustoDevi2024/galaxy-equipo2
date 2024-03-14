using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CuboMovimient : MonoBehaviour
{
    public float rotacion = 1;

    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0 * rotacion, 1 * rotacion, 0 * rotacion);
    }

}
