using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //회전 속력 변수
    public float rotSpeed = 300.0f;

    //회전 각도 제한
    public float rotLimit = 60.0f;

    //회전 누적 변수
    float mx = 0;
    float my = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        //게임 상태가 게임 중 상태가 아니면 업데이트 함수를 종료
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        //사용자 마우스 입력 -> 물체 상하좌우로 회전
        //1.사용자의 마우스 입력
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        my = Mathf.Clamp(my, -rotLimit, rotLimit);

        //2.입력받은 값 이용 회전 방향 결정
        /*Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);
        dir.Normalize();*/

        //3.결정된 회전 방향 회전 속성에 대입
        // R = R0 + VT
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(-my, mx, 0);

        //4.회전 값 중 x축 값을 -90 ~ 90도 사이로 제한
        /*Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90.0f, 90.0f);
        transform.eulerAngles = rot;*/
    }
}
