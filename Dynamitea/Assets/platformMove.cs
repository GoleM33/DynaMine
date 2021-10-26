using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public float moveSpeed;
    public float valueTop;
    public float valueBot;
    public bool move;
    public bool moveUp = true;

    public LayerMask bullet;
    public LayerMask player;
    public GameObject button;

    public float radius;
    public bool playerOff = false;

    void Update()
    {
        if (move == true)
        {
            if (transform.position.y > valueTop)
            {
                moveUp = false;
            }
            if (transform.position.y < valueBot)
            {
                moveUp = true;
            }

            if (moveUp == true)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            }
            else
            {
                if (playerOff == true)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
                }

            }
        }

        if (transform.position.y <= valueBot)
        {
            move = false;
        }

        if (Physics2D.OverlapCircle(button.transform.position, 0.5f, bullet))
        {
            move = true;
        }

        if (Physics2D.OverlapCircle(transform.position, radius, player))
        {
            playerOff = false;
        }
        else
        {
            playerOff = true;
        }
    }
}
