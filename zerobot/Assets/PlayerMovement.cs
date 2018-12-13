using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization

    public Rigidbody rb;
    public float forwardForce;
    public float torque;
    public float backwardForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    /*void Update()
    {
        /*if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddRelativeForce(0, 0, -backwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddRelativeTorque(transform.up * -torque * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddRelativeTorque(transform.up * torque * Time.deltaTime);
        }*/

        /*
        if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(transform.forward * forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddRelativeForce(transform.forward * -backwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddRelativeTorque(transform.up * -torque * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddRelativeTorque(transform.up * torque * Time.deltaTime);
        }*/



        /*if (Input.GetAxis("Vertical") > 0) // Forward movement
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") < 0) // Backward movement
        {
            rb.AddRelativeForce(0, 0, -backwardForce * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") > 0) // Right turn
        {
            rb.AddRelativeTorque(transform.up * torque);
        }
        if (Input.GetAxis("Horizontal") < 0) // Left turn
        {
            rb.AddRelativeTorque(transform.up * -torque);
        }*/

    //}
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}

