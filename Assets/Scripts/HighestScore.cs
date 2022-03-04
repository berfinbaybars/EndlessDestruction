using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{
    public static int highestScore;
    public Text highScore;
    void Start()
    {
        highestScore = PlayerPrefs.GetInt("HighestScore");
        highScore = gameObject.GetComponent<Text>();
        highScore.text = "Highest Score: " + highestScore.ToString();
    }

    public static void setHighScore(int value)
    {
        if(value > highestScore)
        {
            PlayerPrefs.SetInt("HighestScore", value);
        }
    }
}
