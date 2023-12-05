using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmove : MonoBehaviour
{
    Animator animator;
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private float turnSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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

    }
}
