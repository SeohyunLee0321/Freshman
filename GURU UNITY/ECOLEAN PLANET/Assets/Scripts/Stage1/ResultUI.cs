using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultUI : MonoBehaviour
{
    public GameObject failUI;
    public GameObject successUI;

    void Start()
    {
        failUI.SetActive(false);
        successUI.SetActive(false);
    }

    void Update()
    {
        if(Timer.timer.isEnded == true)
        {
            if(Result.result.success == true)
            {
                successUI.SetActive(true);
                
            }
            else
            {
                failUI.SetActive(true);
            }
        }
    }
}
