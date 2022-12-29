using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    float timer;
    float waitingTime_touch;

    public GameObject rule;
    public AudioClip audio;

    AudioSource aSource;

    void Start()
    {
        rule.SetActive(false);

        timer = 0;
        waitingTime_touch = 5.5f;

        aSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timer >= waitingTime_touch)
        {
            rule.SetActive(true);
            aSource.PlayOneShot(audio);
        }
    }
}
