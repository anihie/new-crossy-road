using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] private Text scoreText;

    private int score;

    private void Update()
    {
        scoreText.text = "Score: " + score;
        
    }

    private void FixedUpdate()
    {
        score++;
    }
}
