using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderView : MonoBehaviour
{
    void Update()
    {
        //메인 카메라의 전방 방향 = 나의 전방 방향
        transform.forward = Camera.main.transform.forward;
    }
}