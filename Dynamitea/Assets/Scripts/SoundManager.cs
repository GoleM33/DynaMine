using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip Shoot, Explosion, Reload, Throw;
    static AudioSource audioSrc;


    void Start()
    {
        Shoot = Resources.Load<AudioClip>("Shoot");
        Explosion = Resources.Load<AudioClip>("Explosion");
        Reload = Resources.Load<AudioClip>("Reload");
        Throw = Resources.Load<AudioClip>("Throw");

        audioSrc = GetComponent<AudioSource>();
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "shoot":
                audioSrc.PlayOneShot(Shoot);
                break;
            case "explosion":
                audioSrc.PlayOneShot(Explosion);
                break;
            case "reload":
                audioSrc.PlayOneShot(Reload);
                break;
            case "throw":
                audioSrc.PlayOneShot(Throw);
                break;
        }

    }
}
