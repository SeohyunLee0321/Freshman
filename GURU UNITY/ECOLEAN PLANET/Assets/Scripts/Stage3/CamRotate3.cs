using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate3 : MonoBehaviour
{
    /*//회전 속력 변수 선언
    public float rotSpeed = 300.0f;

    //회전 각도 제한
    public float rotLimit = 60.0f;

    //회전 누적 변수
    float mx = 0;
    float my = 0;

    // Update is called once per frame
    void Update()
    {

        //사용자의 마우스 입력을 받아 물체를 상하 좌우로 회전
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        my = Mathf.Clamp(my, -rotLimit, rotLimit);

        //결정된 회전 방향 -> 물체의 회전 속성에 대입
        transform.eulerAngles = new Vector3(-my, mx, 0);

        //회전 값 중 x축 값 -90 ~ 90도 사이로 제한
        Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90.0f, 90.0f);
        transform.eulerAngles = rot;
    }*/
    public float rotSpeed = 300.0f;

    //회전 각도 제한
    public float rotLimit = 60.0f;

    //회전 누적 변수
    float mx = 0;
    float my = 0;

    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        my = Mathf.Clamp(my, -rotLimit, rotLimit);

        transform.eulerAngles = new Vector3(-my, mx, 0);
    }
}