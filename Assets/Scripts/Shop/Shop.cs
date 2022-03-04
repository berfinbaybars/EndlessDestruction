using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static int gunLevel;
    public static int damageLevel;
    public static int fireRateLevel;
    public static int healthLevel;
    public static int coinModLevel;

    public static bool isReady = false;

    private void Update()
    {
        if (isReady)
        {
            UpdateAll();
            isReady = false;
        }

    }

    public static void UpdateGunLevel()
    {
        gunLevel = PlayerPrefs.GetInt("GunLevel");
        for (int i = 1; i <= gunLevel; i++)
        {
            string levelName = "GunLevel" + i;
            GameObject levelObject = ShopObjects.ObjectLevels[levelName];
            levelObject.GetComponent<RawImage>().color = new Color(0f, 255f, 0f, 255f);
        }
    }

    public static void UpdateDamageLevel()
    {
        damageLevel = PlayerPrefs.GetInt("DamageLevel");
        for (int i = 1; i <= damageLevel; i++)
        {
            string levelName = "DamageLevel" + i;
            GameObject levelObject = ShopObjects.ObjectLevels[levelName];
            levelObject.GetComponent<RawImage>().color = new Color(0f, 255f, 0f, 255f);
        }
    }

    public static void UpdateFireRateLevel()
    {
        fireRateLevel = PlayerPrefs.GetInt("FireRateLevel");
        for (int i = 1; i <= fireRateLevel; i++)
        {
            string levelName = "FireRateLevel" + i;
            GameObject levelObject = ShopObjects.ObjectLevels[levelName];
            levelObject.GetComponent<RawImage>().color = new Color(0f, 255f, 0f, 255f);
        }
    }

    public static void UpdateHealthLevel()
    {
        healthLevel = PlayerPrefs.GetInt("HealthLevel");
        for (int i = 1; i <= healthLevel; i++)
        {
            string levelName = "HealthLevel" + i;
            GameObject levelObject = ShopObjects.ObjectLevels[levelName];
            levelObject.GetComponent<RawImage>().color = new Color(0f, 255f, 0f, 255f);
        }
    }

    public static void UpdateCoinModLevel()
    {
        coinModLevel = PlayerPrefs.GetInt("CoinModLevel");
        for (int i = 1; i <= coinModLevel; i++)
        {
            string levelName = "CoinModLevel" + i;
            GameObject levelObject = ShopObjects.ObjectLevels[levelName];
            levelObject.GetComponent<RawImage>().color = new Color(0f, 255f, 0f, 255f);
        }
    }

    public static void IncreaseGunLevel()
    {
        gunLevel = PlayerPrefs.GetInt("GunLevel");
        if (gunLevel >= 3) return;

        int totalCoin = PlayerPrefs.GetInt("TotalCoin");
        if (totalCoin < ShopCosts.gunCost) return;

        totalCoin -= ShopCosts.gunCost;
        PlayerPrefs.SetInt("TotalCoin", totalCoin);
        
        gunLevel++;
        PlayerPrefs.SetInt("GunLevel", gunLevel);
        UpdateGunLevel();
        ShopCosts.UpdateGunCost();
        TotalCoin.UpdateTotalCoin();

    }
    public static void IncreaseDamageLevel()
    {
        damageLevel = PlayerPrefs.GetInt("DamageLevel");
        if (damageLevel >= 4) return;

        int totalCoin = PlayerPrefs.GetInt("TotalCoin");
        if (totalCoin < ShopCosts.damageCost) return;

        totalCoin -= ShopCosts.damageCost;
        PlayerPrefs.SetInt("TotalCoin", totalCoin);

        damageLevel++;
        PlayerPrefs.SetInt("DamageLevel", damageLevel);
        UpdateDamageLevel();
        ShopCosts.UpdateDamageCost();
        TotalCoin.UpdateTotalCoin();

    }
    public static void IncreaseFireRateLevel()
    {
        fireRateLevel = PlayerPrefs.GetInt("FireRateLevel");
        if (fireRateLevel >= 4) return;

        int totalCoin = PlayerPrefs.GetInt("TotalCoin");
        if (totalCoin < ShopCosts.fireRateCost) return;

        totalCoin -= ShopCosts.fireRateCost;
        PlayerPrefs.SetInt("TotalCoin", totalCoin);

        fireRateLevel++;
        PlayerPrefs.SetInt("FireRateLevel", fireRateLevel);
        UpdateFireRateLevel();
        ShopCosts.UpdateFireRateCost();
        TotalCoin.UpdateTotalCoin();
    }
    public static void IncreaseHealthLevel()
    {
        healthLevel = PlayerPrefs.GetInt("HealthLevel");
        if (healthLevel >= 4) return;

        int totalCoin = PlayerPrefs.GetInt("TotalCoin");
        if (totalCoin < ShopCosts.healthCost) return;
        
        totalCoin -= ShopCosts.healthCost;
        PlayerPrefs.SetInt("TotalCoin", totalCoin);

        healthLevel++;
        PlayerPrefs.SetInt("HealthLevel", healthLevel);
        UpdateHealthLevel();
        ShopCosts.UpdateHealthCost();
        TotalCoin.UpdateTotalCoin();

    }
    public static void IncreaseCoinModLevel()
    {
        coinModLevel = PlayerPrefs.GetInt("CoinModLevel");
        if (coinModLevel >= 4) return;

        int totalCoin = PlayerPrefs.GetInt("TotalCoin");
        if (totalCoin < ShopCosts.coinModCost) return;
        
        totalCoin -= ShopCosts.coinModCost;
        PlayerPrefs.SetInt("TotalCoin", totalCoin);
        
        coinModLevel++;
        PlayerPrefs.SetInt("CoinModLevel", coinModLevel);
        UpdateCoinModLevel();
        ShopCosts.UpdateCoinModCost();
        TotalCoin.UpdateTotalCoin();

    }

    public static void UpdateAll()
    {
        UpdateGunLevel();
        UpdateDamageLevel();
        UpdateFireRateLevel();
        UpdateHealthLevel();
        UpdateCoinModLevel();
    }
}
