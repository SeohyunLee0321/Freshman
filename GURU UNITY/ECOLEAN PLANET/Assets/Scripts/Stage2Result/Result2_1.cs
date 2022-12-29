using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result2_1 : MonoBehaviour
{
    public GameObject planet1o2o3x;
    public GameObject planet1o2x3x;
    /*public Camera success;
    public Camera fail;*/

    void Start()
    {
        planet1o2o3x.SetActive(false);
        planet1o2x3x.SetActive(false);
        /*success.enabled = false;
        fail.enabled = false;*/

        if (Result2.result2.success == true)
        {
            planet1o2o3x.SetActive(true);
            //success.enabled = true;
            AudioManager2.instance.PlayHappy();
        }
        else if (Result2.result2.success == false)
        {
            planet1o2x3x.SetActive(true);
            //fail.enabled = true;
            AudioManager2.instance.PlayBad();
        }
    }


    void Update()
    {
        
    }
}
