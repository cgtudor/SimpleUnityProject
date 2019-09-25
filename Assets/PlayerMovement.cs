using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Rigidbody rb;
    public float movementSpeed = 2.0f;
    public float rotationSpeed = 2.0f;
    Rigidbody rb;
    public GameObject camera;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        
        rb.velocity = new Vector3(mH * movementSpeed, rb.velocity.y, mV * movementSpeed);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate((Vector3.up) * -rotationSpeed);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate((Vector3.up) * rotationSpeed);
        //if (Input.GetAxis("Mouse X") < 0)
        //    transform.Rotate((Vector3.up) * rotationSpeed);
        //if (Input.GetAxis("Mouse X") > 0)
        //    transform.Rotate((Vector3.up) * -rotationSpeed);
    }
}
