using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result3_1 : MonoBehaviour
{
    public GameObject planet1o2x3o;
    public GameObject planet1x2x3x;
    /*public Camera success;
    public Camera fail;*/

    void Start()
    {
        planet1o2x3o.SetActive(false);
        planet1x2x3x.SetActive(false);
        /*success.enabled = false;
        fail.enabled = false;*/

        if (Result3.result3.success == true)
        {
            planet1o2x3o.SetActive(true);
            //success.enabled = true;
            AudioManager3.instance.PlayHappy();
        }
        else if (Result3.result3.success == false)
        {
            planet1x2x3x.SetActive(true);
            //fail.enabled = true;
            AudioManager3.instance.PlayBad();
        }
    }


    void Update()
    {
        
    }
}