/*
Created By: Andrew
Created On: 5/2/22
Created For: Add this to an object with a TMP to have it display score
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI TMP;

    // Start is called before the first frame update
    void Start()
    {
        TMP = GetComponent<TextMeshProUGUI>();
        GameManager.OnScoreUpdate.AddListener(UpdateText);
    }

    private void UpdateText()
    {
        TMP.text = "Secrets: " + GameManager.Score + " / 6";
    }
}
