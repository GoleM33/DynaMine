using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    public LayerMask oil;
    public Rigidbody2D rb;

    public float drag = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 1f, oil))
        {
            rb.drag = 0;
        }
        else
        {
            rb.drag = drag;
        }
    }
}
