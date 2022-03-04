using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private float fireEachSecond = 2;
    private float timePassed = 0f;
    public GameObject Bullet;
    public GameObject BulletLeft;
    public GameObject BulletRight;
    void Start()
    {
        fireEachSecond += (PlayerPrefs.GetInt("FireRateLevel") / 2);
        timePassed = 0f;
    }
    void Update()
    {
        if(timePassed >= (1f / fireEachSecond))
        {
            if(PlayerPrefs.GetInt("GunLevel") == 1)
            {
                Instantiate(Bullet, gameObject.transform.position, Bullet.transform.rotation);
            }
            else if(PlayerPrefs.GetInt("GunLevel") == 2)
            {
                /*Vector3 bullet1 = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                Vector3 bullet2 = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(Bullet, bullet1, Bullet.transform.rotation);
                Instantiate(Bullet, bullet2, Bullet.transform.rotation);*/
                Instantiate(Bullet, gameObject.transform.position, Bullet.transform.rotation);
                Vector3 bulletPos = new Vector3(gameObject.transform.position.x + 4, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(BulletRight, bulletPos, BulletRight.transform.rotation);
            }
            else if (PlayerPrefs.GetInt("GunLevel") == 3)
            {
                /*Vector3 bullet1 = new Vector3(gameObject.transform.position.x + 2, gameObject.transform.position.y, gameObject.transform.position.z);
                Vector3 bullet2 = new Vector3(gameObject.transform.position.x - 2, gameObject.transform.position.y, gameObject.transform.position.z);
                Vector3 bullet3 = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(Bullet, bullet1, Bullet.transform.rotation);
                Instantiate(Bullet, bullet2, Bullet.transform.rotation);
                Instantiate(Bullet, bullet3, Bullet.transform.rotation);*/
                Instantiate(Bullet, gameObject.transform.position, Bullet.transform.rotation);
                Vector3 bulletPos1 = new Vector3(gameObject.transform.position.x + 4, gameObject.transform.position.y, gameObject.transform.position.z);
                Vector3 bulletPos2 = new Vector3(gameObject.transform.position.x - 4, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(BulletRight, bulletPos1, BulletRight.transform.rotation);
                Instantiate(BulletLeft, bulletPos2, BulletLeft.transform.rotation);
            }
            timePassed = 0f;
        }
        timePassed += Time.deltaTime;
    }
}
