using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogwithNpcController : MonoBehaviour
{
   public GameObject NpcBlack;
   public GameObject GhostBlack;

    // Update is called once per frame
    private void Update()
    {
        if (Vector3.Distance(transform.position, NpcBlack.transform.position)<2.0f)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GhostBlack.GetComponent<GhostBlackController>().Appear();
            }

            if (Input.GetKeyDown(KeyCode.G)&& GhostBlack.GetComponent<GhostBlackController>().Isvisible)
            {
                GhostBlack.GetComponent<GhostBlackController>().Disappear();
                NpcBlack.GetComponent<NpcBlackController>().happy_dance();
            }
        }

    
        
    }
}
