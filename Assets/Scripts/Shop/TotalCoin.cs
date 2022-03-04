using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoin : MonoBehaviour
{
    public static Text TotalCoinText;
    public static int totalCoin;
    void Start()
    {
        TotalCoinText = gameObject.GetComponent<Text>();
        UpdateTotalCoin();
    }

    public static void UpdateTotalCoin()
    {
        totalCoin = PlayerPrefs.GetInt("TotalCoin");
        TotalCoinText.text = "Total Coin: " + totalCoin.ToString();
    }
}
