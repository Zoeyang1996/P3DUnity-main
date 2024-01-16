using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcmovement : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2.0f;
    int index = 0;
    public bool isLoop = true;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed* Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if(distance>0.005)
        {
             if (animator.GetInteger("move") != 1)
                {
                    animator.SetFloat("speed", 1);
                    animator.SetInteger("move", 1);
                }
        }
        
        else
        {
            if (animator.GetInteger("move") ! = 0)
            {
                animator.SetInteger("move", 0);
                animator.SetFloat("speed", 1);
                
                if(index < waypoints.Count-1)
                {
                    index++;
                }
                
                else
                {
                    
                    if(isLoop)
                    {
                        index = 0;
                    }
                }
            }
            
        }

    }

}
    