using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinObject : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float speed = 30;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    private void Update()
    {
        if (gameObject.transform.position.y + 10 < Constants.screenYminus)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<BoxCollider2D>());
        if (collision.collider.tag == "Car")
        {
            rb.velocity = new Vector2(0, 0);
            Destroy(gameObject);
            Coin.IncreaseCoin(1);
        }
    }
}
