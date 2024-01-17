using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogwithBread : MonoBehaviour
{
   public GameObject NpcBread;
   public GameObject GhostBread;
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
        if (!interactionComplete && Vector3.Distance(transform.position, NpcBread.transform.position)<5.0f)
        {
            pressFText.SetActive(true);

            if (Input.GetKeyDown("f"))
            {
                GhostBread.GetComponent<GhostBreadController>().Appear();
                pressFText.SetActive(false);
                pressGText.SetActive(true);
            }
        }
            else 
        {
            pressFText.SetActive(false);
            pressGText.SetActive(false);
        }

            if (Input.GetKeyDown("g")&& GhostBread.GetComponent<GhostBreadController>().IsVisible)
            {
                GhostBread.GetComponent<GhostBreadController>().Disappear();
                NpcBread.GetComponent<NpcBreadController>().happy_dance();
                pressGText.SetActive(false);
                pressFText.SetActive(false);
                interactionComplete = true;
            }

    }
}
