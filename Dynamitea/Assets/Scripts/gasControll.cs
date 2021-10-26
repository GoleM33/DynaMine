using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasControll : MonoBehaviour
{
    public GameObject gas1;
    public float timer1;
    public float maxTimer1;
    public float last1;
    public float maxLast1;
    public bool on1;

    public GameObject gas2;
    public float timer2;
    public float maxTimer2;
    public float last2;
    public float maxLast2;
    public bool on2;

    public GameObject gas3;
    public float timer3;
    public float maxTimer3;
    public float last3;
    public float maxLast3;
    public bool on3;

    void Update()
    {
        if (timer1 > 0 && on1 == false)
        {
            gas1.SetActive(false);
            timer1 = timer1 - 1 * Time.deltaTime;
            last1 = maxLast1;
        }
        else
        {
            on1 = true;

        }

        if (last1 > 0 && on1 == true)
        {
            last1 = last1 - 1 * Time.deltaTime;
            gas1.SetActive(true);
            timer1 = maxTimer1;
        }
        else
        {
            on1 = false;

        }



        if (timer2 > 0 && on2 == false)
        {
            gas2.SetActive(false);
            timer2 = timer2 - 1 * Time.deltaTime;
            last2 = maxLast2;
        }
        else
        {
            on2 = true;

        }

        if (last2 > 0 && on2 == true)
        {
            last2 = last2 - 1 * Time.deltaTime;
            gas2.SetActive(true);
            timer2 = maxTimer2;
        }
        else
        {
            on2 = false;

        }



        if (timer3 > 0 && on3 == false)
        {
            gas3.SetActive(false);
            timer3 = timer3 - 1 * Time.deltaTime;
            last3 = maxLast3;
        }
        else
        {
            on3 = true;

        }

        if (last3 > 0 && on3 == true)
        {
            last3 = last3 - 1 * Time.deltaTime;
            gas3.SetActive(true);
            timer3 = maxTimer3;
        }
        else
        {
            on3 = false;

        }
    }
}
