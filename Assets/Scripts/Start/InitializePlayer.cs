using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayer : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("Initialized") != 2)
        {
            Initialize();
        }
    }

    void Initialize()
    {
        PlayerPrefs.SetInt("GunLevel", 1);
        PlayerPrefs.SetInt("DamageLevel", 1);
        PlayerPrefs.SetInt("FireRateLevel", 1);
        PlayerPrefs.SetInt("HealthLevel", 1);
        PlayerPrefs.SetInt("CoinModLevel", 1);
        PlayerPrefs.SetInt("TotalCoin", 0); 
        PlayerPrefs.SetInt("HighestScore", 0);
        PlayerPrefs.SetInt("Initialized", 2);
        PlayerPrefs.SetInt("IsInstructed", 0);
        PlayerPrefs.SetInt("Sound", 1);
    }
}
