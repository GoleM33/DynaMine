using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float ammo = 3;
    public float maxAmmo;

    public float timer;
    public float maxTimer;

    public bool empty;
    public bool empty1;
    public bool clean = false;


    public GameObject chamber3;
    public GameObject chamber2;
    public GameObject chamber1;
    public GameObject chamber0;
    public GameObject reload1;
    public GameObject reload2;

    public bool bullet1;
    public bool bullet2;
    public bool bullet3;
    public bool bullet4;
    public bool bullet5;
    public bool bullet6;
    public bool bullet7;
    public bool bullet8;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (timer > 0)
        {
            timer = timer - 1 * Time.deltaTime;
        }



        if (ammo == 0 && empty == false)
        {
            timer = maxTimer;

            empty = true;

        }

        if (empty == true && (timer <= 0))
        {
            ammo = maxAmmo;
            empty = false;
            empty1 = false;
            bullet1 = false;
            bullet2 = false;
            bullet3 = false;
            bullet4 = false;
            bullet5 = false;
            bullet6 = false;
            bullet7 = false;
            bullet8 = false;

        }


        if (empty == false)
        {
            chamberAction();
        }
        else if (empty1 == false)
        {
            if (ammo == 0)
            {
                chamber3.SetActive(false);
                chamber2.SetActive(false);
                chamber1.SetActive(false);
                chamber0.SetActive(true);
            }

            empty1 = true;
        }

        reload();


    }

    void FixedUpdate()
    {

    }

    void chamberAction()
    {
        if (ammo == 3)
        {
            chamber3.SetActive(true);
            chamber2.SetActive(false);
            chamber1.SetActive(false);
            chamber0.SetActive(false);
            reload1.SetActive(false);
            reload2.SetActive(false);

            chamber0.transform.rotation = Quaternion.identity;
        }

        if (ammo == 2)
        {
            chamber3.SetActive(false);
            chamber2.SetActive(true);
            chamber1.SetActive(false);
            chamber0.SetActive(false);
        }

        if (ammo == 1)
        {
            chamber3.SetActive(false);
            chamber2.SetActive(false);
            chamber1.SetActive(true);
            chamber0.SetActive(false);
        }

        if (ammo == 0)
        {
            chamber3.SetActive(false);
            chamber2.SetActive(false);
            chamber1.SetActive(false);
            chamber0.SetActive(true);
        }
    }

    void reload()
    {
        if (timer <= 8 * maxTimer / 9 && timer > 7 * maxTimer / 9 && bullet5 == false)
        {
            chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            bullet5 = true;
        }


        if (timer <= 7 * maxTimer / 9 && timer > 6 * maxTimer / 9 && bullet6 == false)
        {
            chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            bullet6 = true;
        }

        if (timer <= 6 * maxTimer / 9 && timer > 5 * maxTimer / 9 && bullet7 == false)
        {
            chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            bullet7 = true;
        }

        if (timer <= 5 * maxTimer / 9 && timer > 4 * maxTimer / 9 && bullet8 == false)
        {
            chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            bullet8 = true;
        }

        if (timer <= 4 * maxTimer / 9 && timer > 3 * maxTimer / 9 && bullet2 == false)
        {
            chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            bullet2 = true;
        }

        if (timer <= 3 * maxTimer / 9 && timer > 2 * maxTimer / 9 && bullet3 == false)
        {
            //chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            SoundManager.PlaySound("reload");
            chamber0.SetActive(false);
            reload1.SetActive(true);
            bullet3 = true;

        }

        if (timer <= 2 * maxTimer / 9 && timer > maxTimer / 9 && bullet4 == false)
        {
            //chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            SoundManager.PlaySound("reload");
            reload1.SetActive(false);
            reload2.SetActive(true);
            bullet4 = true;

        }

        if (timer <= maxTimer / 9 && timer > 0 && bullet5 == false)
        {
            //chamber0.transform.Rotate(0f, 0f, -60f, Space.Self);
            SoundManager.PlaySound("reload");
            reload2.SetActive(false);
            chamber3.SetActive(true);
            bullet5 = true;

        }




    }

    void Shoot()
    {
        if (ammo > 0)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            SoundManager.PlaySound("shoot");
            ammo = ammo - 1;
        }

        if (ammo == 0)
        {
            timer = maxTimer;
            empty = true;

        }


    }
}