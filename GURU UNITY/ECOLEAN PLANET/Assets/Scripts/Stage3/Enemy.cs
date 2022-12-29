using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static Enemy enemyS = null;
    //에너미 상태 함수
    enum EnemyState
    {
        Idle,
        Damaged,
        Die
    }

    EnemyState enemyState;

    //에너미 캐릭터 컨트롤러
    CharacterController ec;

    //현제 체력 변수
    public int currentHp;
    [HideInInspector]
    
    //최대 체력 변수
    public int maxHp = 30;

    //슬라이더 변수
    public Slider hpSlider;

    private void Awake()
    {
        if (enemyS == null)
        {
            enemyS = this;
        }
    }

    void Start()
    {
        //현재 체력 설정
        currentHp = maxHp;
        
        //초기 상태 = 대기 상태
        enemyState = EnemyState.Idle;

        //에너미 캐릭터 컨트롤러 받기
        ec = GetComponent<CharacterController>();
    }

    void Update()
    {
        //hp 슬라이더 값에 체력 비율 젹용
        hpSlider.value = (float)currentHp / (float)maxHp;
        
        switch (enemyState)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Damaged:
                Damaged();
                break;
            case EnemyState.Die:
                //Die();
                break;
        }    
    }

    //대기 행동 함수
    void Idle()
    {
        //추후 애니메이션 추가?
        //EnemyManager를 사용해 작은 적 생성
    }

    void Damaged()
    {
        if(currentHp > 0)
        {
            DamageProcess();
        }
        else if(currentHp <= 0)
        {
            enemyState = EnemyState.Die;
            Die();
        }
    }

    IEnumerator DamageProcess()
    {
        //1초간 정지
        yield return new WaitForSeconds(1.0f);
        //이동 상태로 전환
        enemyState = EnemyState.Idle;
        Idle();
    }

    //사망 행동 함수
    void Die()
    {
        //사망 코루틴 함수 실행
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        //에너미 캐릭터 컨트롤러 비활성화
        ec.enabled = false;
        //0.5초간 정지 후 물체 제거
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    //데미지 처리 함수
    public void HitEnemy(int value)
    {
        //사망 상태일 때 함수 종료
        if (enemyState == EnemyState.Die)
        {
            return;
        }

        currentHp -= value;

        //남은 hp가 0보다 크면
        if (currentHp > 0)
        {
            //대기 상태 유지
            enemyState = EnemyState.Idle;
            Idle();
        }
        //그렇지 않다면
        else
        {
            //상태를 사망 상태로 전환
            enemyState = EnemyState.Die;
            Die();
        }
    }
}