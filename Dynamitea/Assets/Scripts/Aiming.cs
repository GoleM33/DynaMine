using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{

    public Rigidbody2D rb;
    public Camera cam;
    public Transform playerGuy;
    
    Vector2 mousePos;

    //variables for pivot point position
    public float x;
    public float y;
    public float z;

    public GameObject arm1;
    public GameObject arm2;
    public Transform point;
    public float angle;



    void Update()
    {
        //read mouse position
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if ((point.transform.rotation.z > -0.65) && (point.transform.rotation.z < 0.65))
        {
            arm1.SetActive(true);
            arm2.SetActive(false);
        }
        else
        {
            arm1.SetActive(false);
            arm2.SetActive(true);
        }

    }

    void FixedUpdate()
    {
        //follow mouse
        Vector2 lookDir = mousePos - rb.position;
        float angle1 = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle1;

        //move to player position (attach)
        transform.position = new Vector3(playerGuy.position.x + x, playerGuy.position.y + y, playerGuy.position.z + z);


    }
}