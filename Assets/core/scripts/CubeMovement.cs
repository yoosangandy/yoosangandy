using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 130.0f, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(0.5f, 0, 0, ForceMode.Impulse);
        }    

        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(0, 0, 0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(0, 0, -0.5f ,ForceMode.Impulse);
        }

        if (transform.position.y < -50)
        {
            transform.position = Vector3.zero;
        }
    }
}
