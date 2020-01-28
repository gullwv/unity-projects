using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f; // speed of vehicle
    private float turnSpeed = 90.0f; // turn speed of vehicle
    private float horizontalInput; // input for left-right
    private float verticalInput; // input for forward-back

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // forward motion for the vehicle.

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); // go forward or backward at the speed in the "speed" float when up-down or w-s pressed
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); //move left or right at the speed in the "turnSpeed" float when left-right or a-d pressed

    }
}
