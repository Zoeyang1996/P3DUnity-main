using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBreadController : MonoBehaviour
{ 
    private Animator animator;

   private void Start()
   {
    animator = GetComponent<Animator>();
   }
    public void happy_dance()
    {
        animator.SetTrigger("happy_dance");
    }


    
}