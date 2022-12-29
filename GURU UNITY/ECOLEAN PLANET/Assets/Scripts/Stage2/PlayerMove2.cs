using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove2 : MonoBehaviour
{
    public static PlayerMove2 move2 = null;
    //중력 변수
    public float gravity = 0.0f;

    //수직 속도 변수
    float yVelocity = 0;

    //속력 변수
    public float moveSpeed = 20.0f;

    //캐릭터 컨트롤러 변수
    CharacterController pc1;

    //현제 체력 변수
    public int Hp;

    //최대 체력 변수
    public int maxHp = 10;

    //슬라이더 변수
    public Slider hpSlider;

    enum PlayS
    {
        Move,
        Die
    }

    PlayS PlayState;

    private void Awake()
    {
        if (move2 == null)
        {
            move2 = this;
        }
    }

    void Start()
    {
        Hp = maxHp; //현재 체력 초기화

        //캐릭터 컨트롤러 컴포넌트 받아옴
        pc1 = GetComponent<CharacterController>();

        PlayState = PlayS.Move;
    }

    void Update()
    {
        //hp 슬라이더 값에 체력 비율 젹용
        hpSlider.value = (float)Hp / (float)maxHp;

        switch (PlayState)
        {
            case PlayS.Move:
                Move();
                break;
            case PlayS.Die:
                Die();
                break;
        }
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        //이동 방향(월드 좌표)을 카메라의 방향 기준으로 (로컬 좌표)전환
        dir = Camera.main.transform.TransformDirection(dir);

        //플레이어가 땅에 있으면 수직 속도는 0
        if (pc1.collisionFlags == CollisionFlags.Below)
        {
            yVelocity = 0;
        }

        //캐릭터 수직 속도(중력) 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //이동 방향으로 플레이어 이동
        pc1.Move(dir * moveSpeed * Time.deltaTime);
    }

    public void Damaged(int DamageV)
    {
        //사망 상태일 때 함수 종료
        if (PlayState == PlayS.Die)
        {
            return;
        }

        if (Hp > 0)
        {
            Hp -= DamageV;
            PlayState = PlayS.Move;
            Move();
        }
        else
        {
            PlayState = PlayS.Die;
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(DieP());
    }

    IEnumerator DieP()
    {
        pc1.enabled = false;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    public void HitPlayer(int HitDamage)
    {
        //사망 상태일 때 함수 종료
        if (PlayState == PlayS.Die)
        {
            return;
        }

        Hp -= HitDamage;

        //남은 hp가 0보다 크면
        if (Hp > 0)
        {
            //이동 상태 유지
            PlayState = PlayS.Move;
            Move();
        }
        //그렇지 않다면
        else
        {
            //상태를 사망 상태로 전환
            PlayState = PlayS.Die;
            Die();
        }
    }
}
