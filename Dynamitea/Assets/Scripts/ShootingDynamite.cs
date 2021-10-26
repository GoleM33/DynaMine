using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingDynamite : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;


    public float timer;
    public float maxTimer;


    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }

        if (timer > 0)
        {
            timer = timer - 1 * Time.deltaTime;
        }

    }
    void Shoot()
    {
        if (timer <= 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            //throw
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            timer = maxTimer;
        }
        

    }
}
