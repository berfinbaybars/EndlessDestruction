using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopObjects : MonoBehaviour
{
    public static Dictionary<string, GameObject> ObjectLevels = new Dictionary<string, GameObject>();

    public GameObject GunLevel1;
    public GameObject GunLevel2;
    public GameObject GunLevel3;
    public GameObject DamageLevel1;
    public GameObject DamageLevel2;
    public GameObject DamageLevel3;
    public GameObject DamageLevel4;
    public GameObject FireRateLevel1;
    public GameObject FireRateLevel2;
    public GameObject FireRateLevel3;
    public GameObject FireRateLevel4;
    public GameObject HealthLevel1;
    public GameObject HealthLevel2;
    public GameObject HealthLevel3;
    public GameObject HealthLevel4;
    public GameObject CoinModLevel1;
    public GameObject CoinModLevel2;
    public GameObject CoinModLevel3;
    public GameObject CoinModLevel4;

    private void Start()
    {
        if (ObjectLevels.Count == 0)
        {
            ObjectLevels.Add("GunLevel1", GunLevel1);
            ObjectLevels.Add("GunLevel2", GunLevel2);
            ObjectLevels.Add("GunLevel3", GunLevel3);
            ObjectLevels.Add("DamageLevel1", DamageLevel1);
            ObjectLevels.Add("DamageLevel2", DamageLevel2);
            ObjectLevels.Add("DamageLevel3", DamageLevel3);
            ObjectLevels.Add("DamageLevel4", DamageLevel4);
            ObjectLevels.Add("FireRateLevel1", FireRateLevel1);
            ObjectLevels.Add("FireRateLevel2", FireRateLevel2);
            ObjectLevels.Add("FireRateLevel3", FireRateLevel3);
            ObjectLevels.Add("FireRateLevel4", FireRateLevel4);
            ObjectLevels.Add("HealthLevel1", HealthLevel1);
            ObjectLevels.Add("HealthLevel2", HealthLevel2);
            ObjectLevels.Add("HealthLevel3", HealthLevel3);
            ObjectLevels.Add("HealthLevel4", HealthLevel4);
            ObjectLevels.Add("CoinModLevel1", CoinModLevel1);
            ObjectLevels.Add("CoinModLevel2", CoinModLevel2);
            ObjectLevels.Add("CoinModLevel3", CoinModLevel3);
            ObjectLevels.Add("CoinModLevel4", CoinModLevel4);
        }
        Shop.isReady = true;
    }
}
