using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    private Animator playerAnim;

    public float jumpForce = 7;
    public float gravityModifier = 2;
    private bool isOnGround = true;

    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        // get the Rigidbody of the object
        playerRb = GetComponent<Rigidbody>();

        // get the Animator component of the object
        playerAnim = GetComponent<Animator>();

        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        
        // jump on a space press if you're on the ground.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");

        }

    }

    // OnCollisionEnter is called when the object collides
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {

            isOnGround = true;

        } else if (collision.gameObject.CompareTag("Obstacle"))
        {

            Debug.Log("NOTIFICATION: Game over, man, game over!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        
        }

    }

}
