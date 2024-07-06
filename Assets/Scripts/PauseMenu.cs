using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseMenu : MonoBehaviour
{

    public bool pauseMenuEnabled;

    public GameObject playerCamera;
    public GameObject pauseMenuCamera;
    public GameObject pauseMenuElements;

    public void Continue()
    {
        print("Continue");
        pauseMenuEnabled = !pauseMenuEnabled;  

        playerCamera.SetActive(true);
        pauseMenuCamera.SetActive(false);
        pauseMenuElements.SetActive(false);
        Cursor.visible = false; 
        Cursor.lockState = CursorLockMode.Locked;     
        print("Pause menu disabled");             
    }

    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }

    void Start()
    {
        pauseMenuEnabled = false;

        playerCamera.SetActive(true);
        pauseMenuCamera.SetActive(false);
        pauseMenuElements.SetActive(false);
        Cursor.visible = false; 
        Cursor.lockState = CursorLockMode.Locked;         
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            print("Esc pressed");
            pauseMenuEnabled = !pauseMenuEnabled;

            if (pauseMenuEnabled == true)
            {
                playerCamera.SetActive(false);
                pauseMenuCamera.SetActive(true);
                pauseMenuElements.SetActive(true);
                Cursor.visible = true; 
                Cursor.lockState = CursorLockMode.Confined; 
                print("Pause menu enabled");                 
            } 
            else
            {             
                playerCamera.SetActive(true);
                pauseMenuCamera.SetActive(false);
                pauseMenuElements.SetActive(false);
                Cursor.visible = false; 
                Cursor.lockState = CursorLockMode.Locked;      
                print("Pause menu disabled");                       
            }
        }
    }
}
