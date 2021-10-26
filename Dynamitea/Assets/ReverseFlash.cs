using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseFlash : MonoBehaviour
{
    public GameObject flash;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("delete", 3f);
    }
    void delete()
    {
        flash.SetActive(true);


    }


    // Update is called once per frame
    void Update()
    {

    }
}