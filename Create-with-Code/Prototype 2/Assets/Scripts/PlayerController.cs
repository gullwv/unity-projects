using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput; //for checking horizontal input.
    
    public float speed = 10; //player movement speed
    public float xRange = 10; //range of the boundaries

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player input and move them
        horizontalInput = Input.GetAxis("Horizontal"); //get input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //move them
        
        // keep the player in bounds
        if (transform.position.x < -xRange) // if the player tries to go left out of range, put em back
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if (transform.position.x > xRange) // if the player tries to go right out of range, put em back
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // fire the fish!
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

    }
}
