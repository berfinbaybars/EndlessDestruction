using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float speed = 20;
    private Vector2 moveDirection;
    public GameObject HealthBar;
    private Vector3 BarScale;
    private float health = 100;
    public GameObject Explosion;
    public Sprite enemyV2;
    public Sprite enemyV3;
    public int damageLevel;
    public float damage;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        moveDirection = new Vector2(0, -speed);

        damageLevel = PlayerPrefs.GetInt("DamageLevel");
        damage = (25f + ((damageLevel - 1f) * 10f));

        if (Score.score >= 25)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = enemyV3;
            damage *= 0.5f;
        }
        else if(Score.score >= 10)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = enemyV2;
            damage *= 0.8f;
        }
        
    }

    void Update()
    {
        if(gameObject.transform.position.y <= 8)
        {
            moveDirection = new Vector2(rb.velocity.x, 0);
        }
        if(gameObject.transform.position.x >= 25 || gameObject.transform.position.x <= -25)
        {
            moveDirection = new Vector2(0, rb.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            DecreaseHealth(damage);
        }
        if (collision.collider.tag == "BulletSmall")
        {
            DecreaseHealth(damage/2);
        }

        if (collision.collider.tag == "Enemy")
        {
            moveDirection = new Vector2(0, 0);
        }
    }

    void DecreaseHealth(float value)
    {
        if (value <= health)
        {
            health -= value;
        }
        else
        {
            health = 0;
        }

        if (health <= 0)
        {
            Score.IncreaseScore(1);
            SoundManager.EnemyExplodedSound();
            Instantiate(Explosion, gameObject.transform.position, Explosion.transform.rotation);
            Destroy(gameObject);
        }

        BarScale = new Vector3(value / 100, 0, 0);
        HealthBar.transform.localScale -= BarScale;
    }
}
