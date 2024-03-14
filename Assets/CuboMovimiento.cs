using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CuboMovimiento : MonoBehaviour
{
    public float speed = 1;
    public float rotacion = 1;
    bool estaMoviendoAlante = true;

    void Update()
    {
        Movement3D();
        Rotation();

    }

    private void Rotation()
    {
        transform.rotation *= Quaternion.Euler(0 * rotacion, 1 * rotacion, 0 * rotacion);
    }

    private void Movement3D()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.back * speed;

        }

        if (estaMoviendoAlante)
        {
            this.transform.position += Vector3.forward * speed;
            if (this.transform.position.z >= 10)
            {
                estaMoviendoAlante = false;
            }
        }
        else
        {
            this.transform.position += Vector3.back * speed;
            if (this.transform.position.z <= 0)
            {
                estaMoviendoAlante = true;
            }
        }
    }

}
