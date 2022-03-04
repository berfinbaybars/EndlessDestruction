using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 25;
    private Vector2 moveDirection;
    private float health = 100;
    private float moveX = 0f;
    private float moveY = 0f;
    public GameObject endPanel;
    public GameObject Gun;
    public static bool dead = false;
    public float enemyDamage;
    public int healthLevel;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        endPanel.SetActive(false);
        health = 100;
        Time.timeScale = 1;
        dead = false;
        healthLevel = PlayerPrefs.GetInt("HealthLevel");
        enemyDamage = healthLevel > 2 ? (25f - (healthLevel * 2.5f)) : (25f - ((healthLevel - 1f) * 5f));
    }

    void Update()
    {
        moveX = 0f;
        moveY = 0f;
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > Constants.screenXminus)
        {
            moveX = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x < Constants.screenX)
        {
            moveX = speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) && gameObject.transform.position.y < Constants.screenY)
        {
            moveY = speed;
        }
        if (Input.GetKey(KeyCode.DownArrow) && gameObject.transform.position.y > Constants.screenYminus)
        {
            moveY = -speed;
        }

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2 && Input.mousePosition.y < Screen.height - 100 &&  gameObject.transform.position.x < Constants.screenX)
            {
                moveX = speed;
            }
            if (Input.mousePosition.x < Screen.width / 2 && Input.mousePosition.y < Screen.height - 100 && gameObject.transform.position.x > Constants.screenXminus)
            {
                moveX = -speed;
            }
        }

        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > Screen.width / 2 && Input.GetTouch(i).position.y < Screen.height - 100 && gameObject.transform.position.x < Constants.screenX)
            {
                moveX = speed;
            }
            if (Input.GetTouch(i).position.x < Screen.width / 2 && Input.GetTouch(i).position.y < Screen.height - 100 && gameObject.transform.position.x > Constants.screenXminus)
            {
                moveX = -speed;
            }

            i++;
        }

        moveDirection = new Vector2(moveX, moveY);
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Coin")
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<BoxCollider2D>());
        }
        if (collision.collider.tag == "EnemyBullet")
        {
            DecreaseHealth(enemyDamage);
        }
        if (collision.collider.tag == "Enemy")
        {
            DecreaseHealth(50);
        }
    }

    private void DecreaseHealth(float value)
    {
        if(value <= health)
        {
            health -= value;
        }
        else
        {
            health = 0;
        }
        HealthBar.SetHealth(health);

        if (health <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        endPanel.SetActive(true);
        HighestScore.setHighScore(Score.score);
        Coin.FinalCoin();
        dead = true;
    }
}
