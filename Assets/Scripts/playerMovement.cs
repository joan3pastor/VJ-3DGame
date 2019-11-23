using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float forwardForce = 1000;
    public float jumpForce = 30;
    public float sideForce = 500;

    Rigidbody rb;
    bool jumping = false;
    float timeBetweenMovements = 0.5f;
    float lastMovementTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (!jumping && Time.time - lastMovementTime >= timeBetweenMovements)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0);
                //jumping = true;
                lastMovementTime = Time.time;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                lastMovementTime = Time.time;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                lastMovementTime = Time.time;
            }
        }
        
    }
}
