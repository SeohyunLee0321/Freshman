using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    //상태 별로 에너미가 상황에 맞는 행동하게 하고 싶다
    //1.에너미상태
    //2.상태별 함수
    //3.switch문 통해서 상태 체크, 상태별 함수 실행

    enum EnemyState
    {
        Idle,
        Move,
        Attack,
        Return,
        Damaged,
        Die
    }

    EnemyState enemyState;

    //플레이어 게임 오브젝트
    GameObject player;

    //감지 범위
    public float findDistance = 8.0f;

    //나의 캐릭터 컨트롤러
    CharacterController cc;

    //이동 속도
    public float moveSpeed = 5.0f;

    //공격 가능 범위
    public float attackDistance = 2.0f;

    //현재 누적 시간 변수
    float currentTime = 0;

    //공격 딜레이 시간
    public float attackDelayTime = 2.0f;

    //공격력 변수
    public int attackPower = 2;

    //초기 위치 회전 저장용 변수
    Vector3 originPos;
    Quaternion originRot;

    //이동 가능한 거리
    public float moveDistance = 20.0f;

    //최대 체력 변수
    public int maxHp = 5;

    //현재 체력 변수
    int currentHp;

    //슬라이더 변수
    public Slider hpSlider;

    //애니메이터 컴포넌트 변수
    Animator anim;

    //네비게이션 메쉬 에이전트
    NavMeshAgent smith;

    void Start()
    {
        //초기 상태는 대기 상태(Idle)
        enemyState = EnemyState.Idle;

        //플레이어 검색
        player = GameObject.Find("Player");

        //캐릭터 컨트롤러 받아오기
        cc = GetComponent<CharacterController>();

        //초기 위치와 회전 저장하기
        originPos = transform.position;
        originRot = transform.rotation;

        //현재 체력 설정
        currentHp = maxHp;

        //자식 오브젝트의 애니메이터 컴포넌트 가져오기
        anim = GetComponentInChildren<Animator>();

        //네브메쉬 에이전트 컴포넌트 가져오기
        smith = GetComponent<NavMeshAgent>();
        smith.speed = moveSpeed;
        smith.stoppingDistance = attackDistance;
    }

    
    void Update()
    {
        //상태 체크용 스위치문
        switch(enemyState)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Move:
                Move();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            case EnemyState.Return:
                Return();
                break;
            case EnemyState.Damaged:
                //Damaged();
                break;
            case EnemyState.Die:
                //Die();
                break;
        }

        //hp 슬라이더의 값에 체력 비율을 적용
        hpSlider.value = (float)currentHp / (float)maxHp;
    }

    //대기 행동 함수
    void Idle()
    {
        //플레이어와의 거리가 감지 범위 이내라면...
        if (Vector3.Distance(player.transform.position, transform.position) <= findDistance)
        {
            //상태를 이동 상태로 변경
            enemyState = EnemyState.Move;
            print("상태 전환 : Idle -> Move");
            anim.SetTrigger("IdleToMove");
        }
    }

    //이동 시 행동 함수
    void Move()
    {
        //이동 거리 밖이라면...
        if (Vector3.Distance(originPos, transform.position) > moveDistance)
        {
            //복귀상태로 변경
            enemyState = EnemyState.Return;
            print("상태 전환 : Move -> Return");
        }
        
        //공격 범위 밖이라면...
        else if (Vector3.Distance(player.transform.position, transform.position) > attackDistance)
        {
            //이동 방향 구하기
            //Vector3 dir = (player.transform.position - transform.position).normalized;

            //나의 전방 방향을 이동 방향과 일치
            //transform.forward = dir;

            //캐릭터 컨트롤러로 이동 방향으로 이동
            //cc.Move(dir * moveSpeed * Time.deltaTime);

            //내브메쉬 에이전트를 이용하여 타겟 방향으로 이동
            smith.SetDestination(player.transform.position);
            smith.stoppingDistance = attackDistance;
        }
        
        //공격 범위 안에 들어오면...
        else
        {
            //상태를 공격 상태로 변경
            enemyState = EnemyState.Attack;
            print("상태 전환 : Move -> Attack");

            anim.SetTrigger("MoveToAttackDelay");

            //공격 대기 시간 미리 누적
            currentTime = attackDelayTime;

            //이동 멈추고, 타겟 초기화
            smith.isStopped = true;
            smith.ResetPath();
        }
    }

    //공격 시 행동 함수
    void Attack()
    {
        //플레이어가 공격 범위 이내라면...
        if (Vector3.Distance(player.transform.position, transform.position) <= attackDistance)
        {
            //현재 대기 시간이 공격 대기 시간을 초과했다면...
            if (currentTime >= attackDelayTime)
            {
                currentTime = 0;

                //플레이어를 공격
                print("공격!");

                anim.SetTrigger("StartAttack");
            }
            else
            {
                //시간 누적
                currentTime += Time.deltaTime;
            }
        }
        else
        {
            //상태를 이동 상태로 전환
            enemyState = EnemyState.Move;
            print("상태 전환 : Attack -> Move");

            anim.SetTrigger("AttackToMove");
        }
    }

    //플레이어에게 데미지를 주는 함수
    public void HitEvent()
    {
        PlayerMove pm = player.GetComponent<PlayerMove>();
        pm.OnDamage(attackPower);
    }

    //복귀 시 행동 함수
    void Return()
    {
        //원래 위치에 도달하지 않았다면, 그 방향으로 이동
        if (Vector3.Distance(originPos, transform.position) > 0.1f)
        {
            //Vector3 dir = (originPos - transform.position).normalized;
            //transform.forward = dir;

            //cc.Move(dir * moveSpeed * Time.deltaTime);

            smith.SetDestination(originPos);
            smith.stoppingDistance = 0;
        }

        //원래 위치에 도달하면 대기 상태로 전환
        else
        {
            smith.isStopped = true;
            smith.ResetPath();

            transform.position = originPos;
            transform.rotation = originRot;

            enemyState = EnemyState.Idle;
            print("상태 전환 : Return -> Idle");
            anim.SetTrigger("MoveToIdle");

            //체력을 최대치로 회복
            currentHp = maxHp;
        }
    }

    //피격 시 행동 함수
    void Damaged()
    {
        //코루틴 함수를 실행
        StartCoroutine(DamageProcess());
    }

    IEnumerator DamageProcess()
    {
        //2초간 정지
        yield return new WaitForSeconds(2.0f);

        //상태 이동 상태로 전환
        enemyState = EnemyState.Move;
        print("상태 전환 : Damaged -> Move");
    }

    //사망 시 행동 함수
    void Die()
    {
        //기존의 예약된 코루틴들을 모두 종료
        StopAllCoroutines();

        //사망 코루틴을 시작
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        //캐릭터 컨트롤러 비활성화
        cc.enabled = false;

        //2초간 기다렸다가 물체 제거
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }

    //데미지 처리 함수
    public void HitEnemy(int value)
    {
        //나의 현재 상태가 피격, 복귀, 사망 상태일 때에는 함수 종료
        if(enemyState == EnemyState.Damaged || enemyState == EnemyState.Return
            || enemyState == EnemyState.Die)
        {
            return;
        }
        
        currentHp -= value;

        //남은 hp가 0보다 크다면...
        if (currentHp > 0)
        {
            //상태를 피격 상태로 전환
            enemyState = EnemyState.Damaged;
            print("상태 전환 : Any state -> Damaged");
            anim.SetTrigger("Damaged");
            Damaged();
        }

        //hprk 0이하라면
        else
        {
            //상태를 사망 상태로 전환
            enemyState = EnemyState.Die;
            print("상태 전환 : Any state -> Die");
            anim.SetTrigger("Die");
            Die();
        }
    }
}
