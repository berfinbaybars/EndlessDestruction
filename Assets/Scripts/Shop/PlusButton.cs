using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusButton : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        if (gameObject.name.StartsWith("Gun"))
        {
            button.onClick.AddListener(Shop.IncreaseGunLevel);
        }
        else if (gameObject.name.StartsWith("Damage"))
        {
            button.onClick.AddListener(Shop.IncreaseDamageLevel);
        }
        else if (gameObject.name.StartsWith("FireRate"))
        {
            button.onClick.AddListener(Shop.IncreaseFireRateLevel);
        }
        else if (gameObject.name.StartsWith("Health"))
        {
            button.onClick.AddListener(Shop.IncreaseHealthLevel);
        }
        else if (gameObject.name.StartsWith("CoinMod"))
        {
            button.onClick.AddListener(Shop.IncreaseCoinModLevel);
        }
    }
}
