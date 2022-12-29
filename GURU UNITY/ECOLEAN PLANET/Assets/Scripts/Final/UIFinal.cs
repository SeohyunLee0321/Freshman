using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFinal : MonoBehaviour
{
    public GameObject endingSuccess;
    public GameObject endingFail;
    public GameObject canvas;

    public Text successNum;
    public Text failNum;

    void Start()
    {
        /*endingSuccess.SetActive(false);
        endingFail.SetActive(false);*/

        if(ResultFinal.resultFinal.finalSuccess == true)
        {
            endingSuccess.SetActive(true);
            
            if (ResultFinal.resultFinal.stageSuccess == 2)
            {
                successNum.text = "2";
            }
            else if (ResultFinal.resultFinal.stageSuccess == 3)
            {
                successNum.text = "3";
            }
        }
        else if (ResultFinal.resultFinal.finalSuccess == false)
        {
            endingFail.SetActive(true);

            if (ResultFinal.resultFinal.stageSuccess == 1)
            {
                failNum.text = "2";
            }
            else if (ResultFinal.resultFinal.stageSuccess == 0)
            {
                failNum.text = "0";
            }
        }
    }

    void Update()
    {
        /*if (ResultFinal.resultFinal.finalSuccess == true)
        {
            endingSuccess.SetActive(true);

            if (ResultFinal.resultFinal.stageSuccess == 2)
            {
                successNum.text = "2";
            }
            else if (ResultFinal.resultFinal.stageSuccess == 3)
            {
                successNum.text = "3";
            }
        }
        else if (ResultFinal.resultFinal.finalSuccess == false)
        {
            endingFail.SetActive(true);

            if (ResultFinal.resultFinal.stageSuccess == 1)
            {
                failNum.text = "2";
            }
            else if (ResultFinal.resultFinal.stageSuccess == 0)
            {
                failNum.text = "0";
            }
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            //endingSuccess.SetActive(false);
            //endingFail.SetActive(false);
            canvas.SetActive(false);
        }
    }
}
