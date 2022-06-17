/*
Created By: Andrew
Created On: 5/2/22
Created For: Put on objects to allow them to give score on being touched
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGiver : MonoBehaviour
{
    public int points = 1;
    public bool destroyOnCollide = true;
    private bool givenPoints = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (givenPoints == false)
        {
            givenPoints = true;
            GameManager.Score += points;
            if (destroyOnCollide)
                Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (givenPoints == false)
        {
            givenPoints = true;
            GameManager.Score += points;
            if (destroyOnCollide)
                Destroy(gameObject);
        }
    }
}
