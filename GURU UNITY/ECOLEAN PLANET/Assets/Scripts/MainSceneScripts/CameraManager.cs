using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    public GameObject title;

    float timer;
    float waitingTime_touch;

    void Start()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;

        timer = 0;
        waitingTime_touch = 5.5f;
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timer >= waitingTime_touch)
        {
            mainCamera.enabled = false;
            subCamera.enabled = true;

            title.SetActive(false);
        }
    }
}
