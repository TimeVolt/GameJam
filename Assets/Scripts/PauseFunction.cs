/*
Created by: Andrew
Created on: 4/26/22
Created for: Pause game, unpause game, bring up pause menu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseFunction : MonoBehaviour
{
    
    public static bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        //stops time, makes pausemenu active
        Time.timeScale = 0;
        isPaused = true;
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        //unstops time, makes pausemenu inactive
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);
    }
}
