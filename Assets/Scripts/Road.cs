using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject RoadDestroyPoint;
    public static float speed = 30;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        RoadDestroyPoint = GameObject.Find("RoadDestroyPoint");
    }

    private void Update()
    {
        if(gameObject.transform.position.y < RoadDestroyPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
