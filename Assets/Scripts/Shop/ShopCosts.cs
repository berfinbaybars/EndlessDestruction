using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCosts : MonoBehaviour
{
    public static int gunLevel;
    public static int damageLevel;
    public static int fireRateLevel;
    public static int healthLevel;
    public static int coinModLevel;

    public static int gunCost;
    public static int damageCost;
    public static int fireRateCost;
    public static int healthCost;
    public static int coinModCost;

    public GameObject gunCostObj;
    public GameObject damageCostObj;
    public GameObject fireRateCostObj;
    public GameObject healthCostObj;
    public GameObject coinModCostObj;

    public static Text gunCostText;
    public static Text damageCostText;
    public static Text fireRateCostText;
    public static Text healthCostText;
    public static Text coinModCostText;

    public GameObject gunPlusObj;
    public GameObject damagePlusObj;
    public GameObject fireRatePlusObj;
    public GameObject healthPlusObj;
    public GameObject coinModPlusObj;

    public static GameObject gunPlus;
    public static GameObject damagePlus;
    public static GameObject fireRatePlus;
    public static GameObject healthPlus;
    public static GameObject coinModPlus;


    private bool isReady = false;

    private void Start()
    {
        gunCostText = gunCostObj.GetComponent<Text>();
        damageCostText = damageCostObj.GetComponent<Text>();
        fireRateCostText = fireRateCostObj.GetComponent<Text>();
        healthCostText = healthCostObj.GetComponent<Text>();
        coinModCostText = coinModCostObj.GetComponent<Text>();

        gunPlus = gunPlusObj;
        damagePlus = damagePlusObj;
        fireRatePlus = fireRatePlusObj;
        healthPlus = healthPlusObj;
        coinModPlus = coinModPlusObj;

        isReady = true;
    }

    private void Update()
    {
        if (isReady)
        {
            UpdateAllCosts();
            isReady = false;
        }
    }

    public static void UpdateGunCost()
    {
        gunLevel = PlayerPrefs.GetInt("GunLevel");
        if(gunLevel == 3)
        {
            gunCostText.text = "MAX";
            gunPlus.SetActive(false);
            return;
        }
        gunCost = gunLevel > 1 ? 2500 : 500;
        gunCostText.text = gunCost.ToString();
    }

    public static void UpdateDamageCost()
    {
        damageLevel = PlayerPrefs.GetInt("DamageLevel");
        if (damageLevel == 4)
        {
            damageCostText.text = "MAX";
            damagePlus.SetActive(false);

            return;
        }
        damageCost = damageLevel > 2 ? damageLevel * 500 : damageLevel * 250;
        damageCostText.text = damageCost.ToString();
    }

    public static void UpdateFireRateCost()
    {
        fireRateLevel = PlayerPrefs.GetInt("FireRateLevel");
        if (fireRateLevel == 4)
        {
            fireRateCostText.text = "MAX";
            fireRatePlus.SetActive(false);

            return;
        }
        fireRateCost = fireRateLevel > 2 ? fireRateLevel * 500 : fireRateLevel * 250;
        fireRateCostText.text = fireRateCost.ToString();
    }

    public static void UpdateHealthCost()
    {
        healthLevel = PlayerPrefs.GetInt("HealthLevel");
        if (healthLevel == 4)
        {
            healthCostText.text = "MAX";
            healthPlus.SetActive(false);

            return;
        }
        healthCost = healthLevel > 2 ? healthLevel * 500 : healthLevel * 250;
        healthCostText.text = healthCost.ToString();
    }

    public static void UpdateCoinModCost()
    {
        coinModLevel = PlayerPrefs.GetInt("CoinModLevel");
        if (coinModLevel == 4)
        {
            coinModCostText.text = "MAX";
            coinModPlus.SetActive(false);

            return;
        }
        coinModCost = coinModLevel > 2 ? coinModLevel * 1000 : coinModLevel * 500;
        coinModCostText.text = coinModCost.ToString();
    }

    public static void UpdateAllCosts()
    {
        UpdateGunCost();
        UpdateDamageCost();
        UpdateFireRateCost();
        UpdateHealthCost();
        UpdateCoinModCost();
    }

}
