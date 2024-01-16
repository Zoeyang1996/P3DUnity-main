using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBlackController : MonoBehaviour
{
    private Animator animator;
    public bool Isvisible { get; private set;}


    private void Start()
    {
        animator = GetComponent<Animator>();
        Isvisible = false;
    }

    public void Appear()
    {
        Isvisible = true;
    }

    public void Disappear()
    {
        
        Isvisible = false;
    }


}
