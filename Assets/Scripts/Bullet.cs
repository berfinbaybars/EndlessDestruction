using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float speed = 40;
    private Vector2 moveDirection;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        moveDirection = new Vector2(0, speed);
    }

    void Update()
    {
        if(gameObject.transform.position.y > 40)
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
        if (collision.collider.tag == "Car" || collision.collider.tag == "EnemyBullet")
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<BoxCollider2D>());
        }
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
