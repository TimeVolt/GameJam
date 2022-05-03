/*
Created by: Andrew S
Created on: 4/25/22
Created for: For use on menu buttons to do stuff, remember to both put on gameobject and put gameobject into onclick slot
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public string levelChange;

    public void ChangeScene()
    {
        SceneManager.LoadScene(levelChange);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
