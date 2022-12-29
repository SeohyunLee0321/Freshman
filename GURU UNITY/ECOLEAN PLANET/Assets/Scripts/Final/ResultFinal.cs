using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultFinal : MonoBehaviour
{
    public static ResultFinal resultFinal;

    public GameObject planet1x2x3x;
    public GameObject planet1x2x3o;
    public GameObject planet1x2o3x;
    public GameObject planet1x2o3o;
    public GameObject planet1o2x3x;
    public GameObject planet1o2x3o;
    public GameObject planet1o2o3x;
    public GameObject planet1o2o3o;

    public int stageSuccess;
    public bool finalSuccess;

    void Start()
    {
        resultFinal = this;

        planet1x2x3x.SetActive(false);
        planet1x2x3o.SetActive(false);
        planet1x2o3x.SetActive(false);
        planet1x2o3o.SetActive(false);
        planet1o2x3x.SetActive(false);
        planet1o2x3o.SetActive(false);
        planet1o2o3x.SetActive(false);
        planet1o2o3o.SetActive(false);

        if (Result.result.success == true && Result2.result2.success == true && Result3.result3.success == true)
        {
            //planet1o2o3o.SetActive(true);
            stageSuccess = 3;
        }
        else if (Result.result.success == true && Result2.result2.success == true && Result3.result3.success == false)
        {
            //planet1o2o3x.SetActive(true);
            stageSuccess = 2;
        }
        else if (Result.result.success == true && Result2.result2.success == false && Result3.result3.success == true)
        {
            //planet1o2x3o.SetActive(true);
            stageSuccess = 2;
        }
        else if (Result.result.success == true && Result2.result2.success == false && Result3.result3.success == false)
        {
            //planet1o2x3x.SetActive(true);
            stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == true && Result3.result3.success == true)
        {
            //planet1x2o3o.SetActive(true);
            stageSuccess = 2;
        }
        else if (Result.result.success == false && Result2.result2.success == true && Result3.result3.success == false)
        {
            //planet1x2o3x.SetActive(true);
            stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == false && Result3.result3.success == true)
        {
            //planet1x2x3o.SetActive(true);
            stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == false && Result3.result3.success == false)
        {
            //planet1x2x3x.SetActive(true);
            stageSuccess = 0;
        }

        if (stageSuccess == 2 || stageSuccess == 3)
        {
            finalSuccess = true;
            print("성공");
            AudioManagerFinal.instance.PlayHappy();
        }
        else if (stageSuccess == 1 || stageSuccess == 0)
        {
            finalSuccess = false;
            print("실패");
            AudioManagerFinal.instance.PlayBad();
        }
    }

    void Update()
    {
        if (Result.result.success == true && Result2.result2.success == true && Result3.result3.success == true)
        {
            planet1o2o3o.SetActive(true);
            //stageSuccess = 3;
        }
        else if (Result.result.success == true && Result2.result2.success == true && Result3.result3.success == false)
        {
            planet1o2o3x.SetActive(true);
            //stageSuccess = 2;
        }
        else if (Result.result.success == true && Result2.result2.success == false && Result3.result3.success == true)
        {
            planet1o2x3o.SetActive(true);
            //stageSuccess = 2;
        }
        else if (Result.result.success == true && Result2.result2.success == false && Result3.result3.success == false)
        {
            planet1o2x3x.SetActive(true);
            //stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == true && Result3.result3.success == true)
        {
            planet1x2o3o.SetActive(true);
            //stageSuccess = 2;
        }
        else if (Result.result.success == false && Result2.result2.success == true && Result3.result3.success == false)
        {
            planet1x2o3x.SetActive(true);
            //stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == false && Result3.result3.success == true)
        {
            planet1x2x3o.SetActive(true);
            //stageSuccess = 1;
        }
        else if (Result.result.success == false && Result2.result2.success == false && Result3.result3.success == false)
        {
            planet1x2x3x.SetActive(true);
            //stageSuccess = 0;
        }

        /*if (stageSuccess == 2 || stageSuccess == 3)
        {
            finalSuccess = true;
        }
        else if(stageSuccess ==0 || stageSuccess == 1)
        {
            finalSuccess = false;
        }*/
    }
}
