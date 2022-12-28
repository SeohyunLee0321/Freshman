using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //지정한 위치로 카메라 위치 변경

    //쫓아다닐 위치 변수
    public Transform followPosition;

    void Start()
    {
        
    }

    
    void Update()
    {
        //나의 위치를 followPosition과 일치시킴
        transform.position = followPosition.position;
    }
}
