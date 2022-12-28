using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    //상하 좌우 입력 받아서 방향(수평)으로 이동
    //1.속력
    //2.방향

    //캐릭터에게 중력(수직)을 적용하고싶다

    //중력 변수
    public float gravity = -20.0f;

    //점프력
    public float jumpPower = 10.0f;

    //최대 점프 횟수
    public int maxJump = 2;

    //현재 점프 횟수
    int jumpCount = 0;

    //수직 속도 변수
    float yVelocity = 0;

    //속력변수
    public float moveSpeed = 7.0f;

    //캐릭터 컨트롤러 변수
    CharacterController cc;

    //체력 변수
    public int hp;

    //최대 체력
    public int maxHp = 10;

    //슬라이더 UI
    public Slider hpSlider;

    //이펙트 UI 오브젝트
    public GameObject hitEffect;

    //애니메이터 컴포넌트 변수
    Animator anim;

    void Start()
    {
        //캐릭터 컨트롤러 컴포넌트를 받아온다
        cc = GetComponent<CharacterController>();

        //체력 변수 초기화
        hp = maxHp;

        //자식 오브젝트의 애니메이터 컴포넌트를 가져온가
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        //슬라이더의 value를 체력 비율로 적용
        hpSlider.value = (float)hp / (float)maxHp;

        //게임 상태가 게임 중 상태가 아니면 업데이트 함수를 종료
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        //이동 방향 벡터의 크기 값을 애니메이터의 이동 블렌드 트리에 전달
        anim.SetFloat("MoveDirection", dir.magnitude);

        //이동 방향을 카메라 방향 기준으로 전환(월드 -> 로컬)
        dir = Camera.main.transform.TransformDirection(dir);

        //플레이어가 땅에 착지하면 현재 점프 횟수를 0으로 초기화
        //수직 속도 값(중력)도 0으로 초기화
        if(cc.collisionFlags == CollisionFlags.Below)
        {
            jumpCount = 0;
            yVelocity = 0;
        }

        //점프키를 누르면, 점프력을 수직 속도로 적용
        //단, 현재 점프 횟수가 최대 점프 횟수를 초과하지 않아야 함
        if(Input.GetButtonDown("Jump") && jumpCount < maxJump)
        {
            jumpCount++;
            yVelocity = jumpPower;
        }

        //캐릭터의 수직속도(중력)을 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //이동 방향으로 플레이어 이동
        //P = P0 + VT
        //transform.position += dir * moveSpeed * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }

    //플레이어 피격 함수
    public void OnDamage(int value)
    {
        hp -= value;
        if(hp < 0)
        {
            hp = 0;
        }
        //hp가 0보다 큰 경우에는 피격 이펙트 코루틴을 실행
        else
        {
            StartCoroutine(HitEffect());
        }
        
        IEnumerator HitEffect()
        {
            //1.이펙트 활성화
            hitEffect.SetActive(true);

            //2.0.3초 기다린다
            yield return new WaitForSeconds(0.3f);

            //3.이펙트 비활성화
            hitEffect.SetActive(false);
        }
    }
}
