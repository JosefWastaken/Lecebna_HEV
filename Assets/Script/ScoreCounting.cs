using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounting : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public static ScoreCounting Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void Count()
    {
        score++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Skóre: " + score;
    }
}

