using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeysMovementCamera : MonoBehaviour
{

    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        Movement3D();

    }

    private void Movement3D()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speed;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.back * speed;

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.forward * speed;

        }
    }

}
