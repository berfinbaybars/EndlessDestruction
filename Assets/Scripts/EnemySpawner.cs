using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    private Vector3 position;
    private float timePassed = 0;

    void Start()
    {
        timePassed = 0;
    }

    void Update()
    {
        if(timePassed > 4f / (Score.difficulty + 1))
        {
            position = new Vector3(Random.Range(Constants.screenXminus, Constants.screenX), gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(Enemy, position, Enemy.transform.rotation);
            timePassed = 0;
        }
        timePassed += Time.deltaTime;
    }
}
