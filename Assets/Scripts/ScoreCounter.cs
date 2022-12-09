using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score;
    private float timeBeetweenAddingScore;
    void Start()
    {

    }

    void FixedUpdate()
    {
            if (Time.timeScale > 0)
            {
                score++;
                scoreText.text = ""+score/10;
                timeBeetweenAddingScore += 0.2f;
            }
    }

    public void SetStartTime()
    {
        timeBeetweenAddingScore = 0.2f;
    }
}
