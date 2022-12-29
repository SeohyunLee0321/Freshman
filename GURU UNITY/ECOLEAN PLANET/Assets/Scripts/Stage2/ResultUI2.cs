using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultUI2 : MonoBehaviour
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
        if (ScoreManager.scoremanager.CScore == 25 || PlayerMove2.move2.Hp == 0)
        {
            if (Result2.result2.success == true)
            {
                successUI.SetActive(true);
                failUI.SetActive(false);
            }
            else
            {
                failUI.SetActive(true);
                successUI.SetActive(false);
            }
        }
    }
}
