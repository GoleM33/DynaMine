using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float timer;
    public float destorTimer;
    public GameObject button;
    public LayerMask bullet;
    void Update()
    {
        if (Physics2D.OverlapCircle(button.transform.position, 0.5f, bullet))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Wheel"))
        {
            Invoke("DropPlatform", timer);
            Destroy(gameObject, destorTimer);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
    }
    

}
