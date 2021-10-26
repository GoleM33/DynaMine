using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public GameObject flash;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("delete",1f);
    }
    void delete() {
        flash.SetActive(false);


    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
