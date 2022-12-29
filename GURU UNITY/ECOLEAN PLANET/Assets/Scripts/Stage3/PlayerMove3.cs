using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove3 : MonoBehaviour
{
    //중력 변수
    public float gravity = 0.0f;

    //수직 속도 변수
    float yVelocity = 0;

    //속력 변수
    public float moveSpeed = 7.0f;

    //캐릭터 컨트롤러 변수
    CharacterController pc;

    void Start()
    {
        //캐릭터 컨트롤러 컴포넌트 받아옴
        pc = GetComponent<CharacterController>();

        //모바일 환경에서 조이스틱 사용
        //#if UNITY_ANDROID
        //GameObject.Find("조이스틱 에셋 이름").SetActive(true);
        //#elif UNITY_EDITOR || UNITY_STANDALONE
        //GameObject.Find("조이스틱 에셋 이름").SetActive(false);
        //#endif
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        //이동 방향(월드 좌표)을 카메라의 방향 기준으로 (로컬 좌표)전환
        dir = Camera.main.transform.TransformDirection(dir);

        //플레이어가 땅에 있으면 수직 속도는 0
        if (pc.collisionFlags == CollisionFlags.Below)
        {
            yVelocity = 0;
        }

        //캐릭터 수직 속도(중력) 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //이동 방향으로 플레이어 이동
        pc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
