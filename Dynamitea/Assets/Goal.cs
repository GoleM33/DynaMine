using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    public float goal;

    void Update()
    {
        if (transform.position.y > goal)
        {
            SceneManager.LoadScene("Ending");
        }
    }

}