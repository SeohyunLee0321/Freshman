using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    //회전 속력 변수
    public float rotSpeed = 300.0f;

    //회전 누적 변수
    float mx = 0;

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

        //2.입력받은 값 이용 회전 방향 결정
        //Vector3 dir = new Vector3(0, mouse_X, 0);
        //dir.Normalize();
        mx += mouse_X * rotSpeed * Time.deltaTime;

        //3.결정된 회전 방향 회전 속성에 대입
        // R = R0 + VT
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }
}
