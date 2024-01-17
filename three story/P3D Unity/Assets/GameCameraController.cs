using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCameraController : MonoBehaviour
{
    public GameObject gameStartPanel; // Assign the panel with the dark transparent background in the inspector
    public Camera mainCamera; // Assign the main camera in the inspector
    private Vector3 gameStartCameraPosition; // The position the camera should start at

    void Start()
    {
        // Optionally set the camera's starting position if it's supposed to move
        gameStartCameraPosition = new Vector3(/* x, y, z coordinates of GameStart surface */);
        mainCamera.transform.position = gameStartCameraPosition; 

        // Show the game start panel
        gameStartPanel.SetActive(true);
        Time.timeScale = 0; // Pause the game
    }

    void Update()
    {
        // Wait for the player to press the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Hide the game start panel
            gameStartPanel.SetActive(false);
            Time.timeScale = 1; // Resume the game

            // If the camera needs to move from the start position, handle that here
            // For example, if the camera needs to follow the player, you would enable the camera follow script here
        }
    }
}
