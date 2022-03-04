using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public static int coin = 0;
    public static int runCoin = 0;
    public GameObject endCoin;
    public GameObject totalCoin;
    public static Text endCoinText;
    public static Text totalCoinText;
    public static Text coinUIText;
    void Start()
    {
        endCoinText = endCoin.GetComponent<Text>();
        totalCoinText = totalCoin.GetComponent<Text>();
        coinUIText = gameObject.GetComponent<Text>();
        coin = 0;
        runCoin = 0;
    }

    void Update()
    {
        
    }

    public static void IncreaseCoin(int value)
    {
        coin += value;
        coinUIText.text = coin.ToString();
    }
    public static void FinalCoin()
    {
        float coinMod = 1f;
        if (PlayerPrefs.GetInt("CoinModLevel") > 1)
        {
            coinMod = (1 + (PlayerPrefs.GetInt("CoinModLevel") / 4f));
        }
        runCoin = (int)(coin * Score.score * coinMod);
        PlayerPrefs.SetInt("TotalCoin", PlayerPrefs.GetInt("TotalCoin") + runCoin);
        endCoinText.text = "Coin: " + coin.ToString() + " x " + Score.score.ToString() + " x " + coinMod.ToString() + " = " + runCoin.ToString();
        totalCoinText.text = "Total Coin: " + PlayerPrefs.GetInt("TotalCoin").ToString();
    }
}
