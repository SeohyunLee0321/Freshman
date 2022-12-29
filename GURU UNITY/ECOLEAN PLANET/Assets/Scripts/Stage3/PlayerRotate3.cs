using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate3 : MonoBehaviour
{
    //회전 속력 변수
    public float rotSpeed = 300.0f;

    //회전 누적 변수
    float mx = 0;

    void Update()
    {
        //마우스 입력 받기
        float mouse_X = Input.GetAxis("Mouse X");

        //입력받은 값으로 회전 방향 결정
        mx += mouse_X * rotSpeed * Time.deltaTime;

        //결정된 회전 방향 물체 회전 속성에 대입
        transform.eulerAngles = new Vector3(0, mx, 0);
    }
}