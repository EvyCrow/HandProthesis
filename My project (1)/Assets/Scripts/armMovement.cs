using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/*
    As you can understand from the name, 
    this script is responsible for moving 
    the hand in space along three axes + rotation
 */

public class armMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 30.0f;
    public float rotationSpeed = 1.0f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal")*speed;
        float verticalInput = Input.GetAxis("Vertical")*speed;
        float forwardInput = Input.GetAxis("z-axis") * speed;
        float rotationInput = Input.GetAxis("rotation") * rotationSpeed;


        _rigidbody.AddForce(horizontalInput, forwardInput, verticalInput);
        _rigidbody.AddTorque(0f, 0f, rotationInput);
    }
    
}
