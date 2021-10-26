using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public float timer = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer = timer - 1 * Time.deltaTime;
        }

        if (timer <= 0)
        {
            Destroy(gameObject, timer);
        }
    }
}
