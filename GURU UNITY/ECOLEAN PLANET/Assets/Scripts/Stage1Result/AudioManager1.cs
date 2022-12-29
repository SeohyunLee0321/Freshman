using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip happy;
    public AudioClip bad;

    public static AudioManager1 instance;

    void Awake()
    {
        if(AudioManager1.instance == null)
        {
            AudioManager1.instance = this;
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
