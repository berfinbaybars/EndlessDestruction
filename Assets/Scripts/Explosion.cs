using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float timePassed = 0f;
    void Start()
    {
        timePassed = 0f;
    }
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed >= 0.8f)
        {
            Destroy(gameObject);
        }
    }
}
