using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public UnityEngine.UI.Text text_Timer;
    private float time_current;
    public float time_Max = 60.0f;
    public bool isEnded;
    //public GameObject endUI;

    private void Start()
    {
        Reset_Timer();
        //endUI.SetActive(false);

        timer = this;
    }
    void Update()
    {
        if (isEnded)
            return;

        Check_Timer();
    }

    private void Check_Timer()
    {

        if (0 < time_current)
        {
            time_current -= Time.deltaTime;
            text_Timer.text = $"{time_current:N1}";
            //Debug.Log(time_current);
        }
        else if (!isEnded)
        {
            End_Timer();
        }


    }

    public static Timer timer;

    public void End_Timer()
    {
        Debug.Log("End");
        time_current = 0;
        text_Timer.text = $"{time_current:N1}";
        isEnded = true;

        Time.timeScale = 0;
    }


    private void Reset_Timer()
    {
        time_current = time_Max;
        text_Timer.text = $"{time_current:N1}";
        isEnded = false;
        Debug.Log("Start");
    }
}
