using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result1 : MonoBehaviour
{
    public GameObject planet1o2x3x;
    public GameObject planet1x2x3x;
    public Camera success;
    public Camera fail;

    void Start()
    {
        planet1o2x3x.SetActive(false);
        planet1x2x3x.SetActive(false);
        success.enabled = false;
        fail.enabled = false;

        if(Result.result.success == true)
        {
            planet1o2x3x.SetActive(true);
            success.enabled = true;
            AudioManager1.instance.PlayHappy();
        }
        else if(Result.result.success == false)
        {
            planet1x2x3x.SetActive(true);
            fail.enabled = true;
            AudioManager1.instance.PlayBad();
        }
    }

    
    void Update()
    {
        
    }
}
