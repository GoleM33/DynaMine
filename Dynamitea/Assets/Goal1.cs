using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal1 : MonoBehaviour
{
    public LayerMask oil;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 1f, oil))
        {
            Debug.Log("fuck");
            SceneManager.LoadScene("Ending");
        
    }
    }
}
