using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public static GameObject Healthbar;
    private void Start()
    {
        Healthbar = gameObject;
    }

    public static void SetHealth(float health)
    {
        health /= 100;
        Healthbar.transform.localScale = new Vector3(health, Healthbar.transform.localScale.y, Healthbar.transform.localScale.z);
    }
}
