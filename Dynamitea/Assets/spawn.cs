using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour

{
    public GameObject block;
    public GameObject button;
    public LayerMask bullet;
    public Transform Spawn;
    void Update()
    {
        if (Physics2D.OverlapCircle(button.transform.position, 1f, bullet))
        {
            Debug.Log("UPS");
            Instantiate(block, Spawn.transform.position, Spawn.transform.rotation);
        }
    }
    

}

