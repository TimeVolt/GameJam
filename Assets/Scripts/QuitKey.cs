using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitKey : MonoBehaviour
{
    public KeyCode quitKey = KeyCode.Escape;

    void Update()
    {
        if (Input.GetKey(quitKey))
        {
            Application.Quit();
        }
    }
}
