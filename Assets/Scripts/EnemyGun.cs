using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBullet;
    private float fireEachSecond = 0.8f;
    private float timePassed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timePassed >= (1f / FireRate()))
        {
            Instantiate(EnemyBullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), EnemyBullet.transform.rotation);
            timePassed = 0f;
        }
        timePassed += Time.deltaTime;
    }

    private float FireRate()
    {
        return (fireEachSecond + Score.difficulty) < 2f ? (fireEachSecond + Score.difficulty) : 2f;
    }
}
