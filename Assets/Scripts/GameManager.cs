/*
Created by: Andrew
Created on: 5/2/22
Created for: Kind of like a static variable, where theres only one, and its global
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static int score = 0;

    public static UnityEvent OnScoreUpdate = new UnityEvent();

    public static int Score
    {
        //return the value of score
        get => score;
        set
        {
            //set the score that the previous thing returned send an event that it updated
            score = value;
            OnScoreUpdate.Invoke();
        }
    }
}
