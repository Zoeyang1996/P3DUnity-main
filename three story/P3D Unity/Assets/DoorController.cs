using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;

   private void Start()
   {
    animator = GetComponent<Animator>();
   }
   
    public void DoorOpen()
    {
        animator.SetTrigger("open");
    }

     public void DoorClose()
    {
        animator.SetTrigger("close");
    }
}
