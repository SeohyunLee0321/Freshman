using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager3 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip happy;
    public AudioClip bad;

    public static AudioManager3 instance;

    void Awake()
    {
        if (AudioManager3.instance == null)
        {
            AudioManager3.instance = this;
        }
    }

    void Update()
    {

    }

    public void PlayHappy()
    {
        audioSource.PlayOneShot(happy);
    }
    public void PlayBad()
    {
        audioSource.PlayOneShot(bad);
    }
}
