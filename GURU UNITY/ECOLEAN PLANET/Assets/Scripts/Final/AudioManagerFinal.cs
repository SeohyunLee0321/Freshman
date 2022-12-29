using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerFinal : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip happy;
    public AudioClip bad;

    public static AudioManagerFinal instance;

    void Awake()
    {
        if (AudioManagerFinal.instance == null)
        {
            AudioManagerFinal.instance = this;
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
