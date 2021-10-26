using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming1r : MonoBehaviour
{

    public Rigidbody2D rb;
    public Camera cam;
    public Transform playerGuy;


    Vector2 mousePos;

    void Awake()
    {

    }

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {

        Vector2 lookDir = mousePos - rb.position;
        float angle1 = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle1;


        transform.position = new Vector3(playerGuy.position.x, playerGuy.position.y, playerGuy.position.z);
    }
}