using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float speed = 40;
    private Vector2 moveDirection;
    public GameObject Car;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Car = GameObject.Find("Car");
        moveDirection = (Car.transform.position - gameObject.transform.position).normalized * speed;
        if(Score.score >= 25)
        {
            gameObject.transform.localScale = new Vector3(1.6f, 1.6f, 1f);
        }
        else if(Score.score >= 10)
        {
            gameObject.transform.localScale = new Vector3(1.4f, 1.4f, 1f);
        }
    }
    void Update()
    {
        if (gameObject.transform.position.y > 50 || gameObject.transform.position.y < -50)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy" || collision.collider.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<BoxCollider2D>());
        }
        if (collision.collider.tag == "Car")
        {
            Destroy(gameObject);
        }
    }
}
