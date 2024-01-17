using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogwithNpcController : MonoBehaviour
{
   public GameObject NpcBlack;
   public GameObject GhostBlack;
   public GameObject pressFText; 
   public GameObject pressGText;
 
   
   private bool interactionComplete = false;

    // Update is called once per frame

    private void Start()
    {
        pressFText.SetActive(false);
        pressGText.SetActive(false);
        
    
    }

    private void Update()
    {
        if (!interactionComplete && Vector3.Distance(transform.position, NpcBlack.transform.position)<5.0f)
        {
            pressFText.SetActive(true);

            if (Input.GetKeyDown("f"))
            {
                GhostBlack.GetComponent<GhostBlackController>().Appear();
                pressFText.SetActive(false);
                pressGText.SetActive(true);
            }
        }
            else 
        {
            pressFText.SetActive(false);
            pressGText.SetActive(false);
        }

            if (Input.GetKeyDown("g")&& GhostBlack.GetComponent<GhostBlackController>().Isvisible)
            {
                GhostBlack.GetComponent<GhostBlackController>().Disappear();
                NpcBlack.GetComponent<NpcBlackController>().happy_dance();
                pressGText.SetActive(false);
                pressFText.SetActive(false);
                interactionComplete = true;
            }

    }
}
