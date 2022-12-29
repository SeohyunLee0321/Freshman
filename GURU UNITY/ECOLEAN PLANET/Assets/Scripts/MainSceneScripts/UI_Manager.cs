using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    float timer;
    float waitingTime_UI;
    float waitingTime_touch;

    public AudioClip audio;
    public GameObject title;

    AudioSource aSource;

    void Start()
    {
        title.SetActive(false);

        timer = 0;
        waitingTime_UI = 3.5f;
        waitingTime_touch = 5;

        aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= waitingTime_UI && timer <= waitingTime_touch)
        {
            title.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                aSource.PlayOneShot(audio);
            }
        }
    }
}
