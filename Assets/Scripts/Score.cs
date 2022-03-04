using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static float difficulty = 0f;
    private static int scorePassed = 0;
    public Text scoreText;
    public GameObject endScore;
    public Text endScoreText;
    

    void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
        endScoreText = endScore.GetComponent<Text>();
        score = 0;
        scorePassed = 0;
        difficulty = 0f;
    }

    void Update()
    {
        scoreText.text = score.ToString();
        endScoreText.text ="Score: " + score.ToString();
        if (scorePassed >= 5)
        {
            difficulty += 0.1f;
            scorePassed = 0;
        }
    }

    public static void IncreaseScore(int value)
    {
        score += value;
        scorePassed += value;
    }
}
