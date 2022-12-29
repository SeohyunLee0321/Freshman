using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip happy;
    public AudioClip bad;

    public static AudioManager2 instance;

    void Awake()
    {
        if (AudioManager2.instance == null)
        {
            AudioManager2.instance = this;
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