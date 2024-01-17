using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Text CountDownText; // Assign in the inspector

    private float timeRemaining = 600; // 10 minutes in seconds

    void Start()
    {
       
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateCountDownUI();
        }
       
    }

    void UpdateCountDownUI()
    {
        // Format the time remaining into minutes and seconds
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        CountDownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

   
}
