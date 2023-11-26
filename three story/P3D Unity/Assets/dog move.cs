using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogmove : MonoBehaviour
{

public float speed = 5.0f;
private Animator animator;

void start()
{
    animator = GetComponent<Animator>();
}
    // Update is called once per frame
    void Update()
    {
        //walking
      if (Input.GetkeyDown(KeyCode.W))
      {
        StartCoroutine(MoveDog());

      }
      }

      IEnumerator MoveDog()
      {
        animator.SetTrigger("shiba dog");
        yield return new WaitForSeconds(2);

      }


    }
}
