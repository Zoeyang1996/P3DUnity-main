using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmove : MonoBehaviour
{
    Animator animator;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("w"))
        {
        animator.SetBool("isWalking", true);
        transform.Translate ( Vector3.forward*speed * Time.deltaTime);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false);

        }

    }
}
