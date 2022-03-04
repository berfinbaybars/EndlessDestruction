using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject Road;
    Vector3 position;

    void Start()
    {
        SpawnPoint = GameObject.Find("RoadSpawnPoint");
    }

    void Update()
    {
        if(SpawnPoint.transform.position.y > gameObject.transform.position.y)
        {
            position = new Vector3(0, gameObject.transform.position.y + 90, 0);
            Instantiate(Road, position, Road.transform.rotation);
            Destroy(gameObject);
        }
    }
}
