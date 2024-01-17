using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmove : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;
    public float speed = 2.0f;
    public float turnSpeed = 20.0f;

    public float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // move forward 
        if (Input.GetKey("w"))
        {
        animator.SetBool("isWalking", true);
        transform.Translate ( Vector3.forward*speed * Time.deltaTime);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false);

        }
        // turn left
        if (Input. GetKey("a"))
        {
            animator.SetBool("isLeft", true);
            // float rotateValue = Vector3.down * turnSpeed * Time.deltaTime;
            // Debug.Log("rotate value " + rotateValue);
            // transform.Rotate(rotateValue);
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isLeft", false);

        }
        
        // turn right
        if (Input.GetKey("d"))
        {
            animator.SetBool("isRight", true);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isRight", false);

        }

         if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set the Jump trigger on the Animator to start the jump animation
            animator.SetTrigger("Jump");

            // Add a vertical force to the Rigidbody to perform the jump
            transform.Translate(Vector3.up * jumpForce);
        }

    }
}
