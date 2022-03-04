using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    private float timePassed = 0;
    private Vector3 position;

    void Start()
    {
        timePassed = 0;
    }

    void Update()
    {
        if (timePassed > 5f)
        {
            position = new Vector3(Random.Range(Constants.screenXminus, Constants.screenX), gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(Coin, position, Coin.transform.rotation);
            timePassed = 0;
        }
        timePassed += Time.deltaTime;
    }
}
