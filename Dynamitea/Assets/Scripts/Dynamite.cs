using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour
{
    public LayerMask player;
    public LayerMask projectile;

    public float hitRadius = 1f;
    public float timer;
    public float detonTimer;

    public bool detonation = false;

    public GameObject explosion;

    void Update()
    {
        if (detonTimer > 0)
        {
            detonTimer = detonTimer - 1 * Time.deltaTime;
        }
        else
        {
            detonation = true;
        }

    }

    void FixedUpdate()
    {



        if (Physics2D.OverlapCircle(transform.position, hitRadius, projectile) || detonation == true)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            SoundManager.PlaySound("explosion");
            gameObject.SetActive(false);
            Destroy(gameObject, timer);


        }
    }

}
