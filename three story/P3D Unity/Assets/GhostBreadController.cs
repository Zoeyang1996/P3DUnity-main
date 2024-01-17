using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBreadController : MonoBehaviour
{
   
    private Animator animator;
    public bool IsVisible { get; private set;}

    private void Start()
    {
        animator = GetComponent<Animator>();
        IsVisible = false;
    }

    public void Appear()
    {
        IsVisible = true;
        animator.SetBool("IsVisible", true);
    }

    public void Disappear()
    {
        IsVisible = false;
        animator.SetBool("IsVisible", false);
    }

}
