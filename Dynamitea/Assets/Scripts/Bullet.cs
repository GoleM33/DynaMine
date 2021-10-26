using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask barrier;
    public LayerMask dynamite;

    public float hitRadius;
    public float timer;

    void FixedUpdate() 
        {
            if (Physics2D.OverlapCircle(transform.position, 0f, barrier))
                {
                    Destroy(gameObject);
                }

        if (Physics2D.OverlapCircle(transform.position, hitRadius, dynamite))
        {
            Destroy(gameObject, timer);
        }

    }
}
