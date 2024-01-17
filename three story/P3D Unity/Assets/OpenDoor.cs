using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject pressFText; 
    public GameObject Door;
    public AudioSource barking;

     void Start()
    {
        pressFText.SetActive(false);
        barking.playOnAwake = false;
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.G))
        {
            // Play the bark sound
            barking.Play();
        }

        if ( Vector3.Distance(transform.position, Door.transform.position)<3.0f)
        {
            pressFText.SetActive(true);

            if (Input.GetKeyDown("f"))
            {
                Door.GetComponent<DoorController>().DoorOpen();
                pressFText.SetActive(false);

            }

        }

        else
        {
            pressFText.SetActive(false);
        }
    }



}
