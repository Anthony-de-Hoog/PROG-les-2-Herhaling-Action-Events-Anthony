using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        Pickup.OnPickup += GetPoints;
    }

    void Update()
    {
        textField.text = "score: " + score;
    }
    private void GetPoints()
    {
        score += 50;
        textField.text = "score: " + score;
    }
}
