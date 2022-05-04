/*
Created By: Andrew S
Created On: 5/4/22
Created For: Triggering a scene change on the player touching an EndTrigger tagged gameObject
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTrigger : MonoBehaviour
{
    public string levelChange;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EndTrigger"))
        {
            SceneManager.LoadScene(levelChange);
        }
    }
}
