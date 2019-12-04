using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float forwardForce = 1000;
    public float jumpForce = 30;
    public float sideForce = 500;
    public float maxVelocity = 6;
    public bool dead = false;

    Rigidbody rb;
    bool jumping = false;
    float timeBetweenMovements = 0.5f;
    float lastMovementTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }


    void Update() {

        Vector3 vel = rb.velocity;
        if (vel.z > maxVelocity)
        {
            vel.z = maxVelocity;
            rb.velocity = vel;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            //rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            lastMovementTime = Time.time;
            vel.x = -3;
            rb.velocity = vel;
            //Debug.Log(rb.velocity);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            //rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            lastMovementTime = Time.time;
            vel.x = 3;
            rb.velocity = vel;
        }

    }
    void FixedUpdate()
    {
        if (!dead) { 
        
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
            
            if (!jumping && Time.time - lastMovementTime >= timeBetweenMovements)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    rb.AddForce(0, jumpForce * Time.deltaTime, 0);
                    lastMovementTime = Time.time;
                }
            }

        }
        
    }
}
