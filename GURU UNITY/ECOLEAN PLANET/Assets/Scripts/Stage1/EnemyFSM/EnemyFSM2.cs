using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyFSM2 : MonoBehaviour
{
    enum EnemyState
    {
        Idle,
        Attack,
        //AttackDelay,
        Damaged,
        Die
    }
    EnemyState enemyState;

    ParticleSystem ps;
    ParticleSystem ps1;
    AudioSource aSource;

    GameObject wall;
    public GameObject enemy;
    public GameObject enemyDead;
    //public AudioClip dyingSound;
    //public AudioClip firesound;
    public GameObject dyingEffect;
    public GameObject fireEffect;
    public Transform firePosition;
    public Transform explodePositon;
    public Slider hpSlider;

    float currentTime = 0;
    public float attackDelayTime = 1.0f;
    public float attackPower = 1.0f;
    public int maxHp = 5;
    public int currentHp;

    void Start()
    {
        enemyState = EnemyState.Attack;

        wall = GameObject.Find("Wall2");

        currentHp = maxHp;

        aSource = GetComponent<AudioSource>();
        ps = fireEffect.GetComponent<ParticleSystem>();
        ps1 = dyingEffect.GetComponent<ParticleSystem>();

        enemy.SetActive(true);
        enemyDead.SetActive(false);
    }

    void Update()
    {
        switch (enemyState)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            /*case EnemyState.AttackDelay:
                AttackDelay();
                break;*/
            case EnemyState.Damaged:
                Damaged();
                break;
            case EnemyState.Die:
                //Die();
                break;
                /*case default:
                    Idle();
                    break;*/
        }
        hpSlider.value = (float)currentHp / (float)maxHp;
    }

    /*void PlaySound(string action)
    {
        switch(action)
        {
            case "fireBullet":
                aSource.clip = firesound;
                break;
            case "enemyDie":
                aSource.clip = dyingSound;
                break;
        }
        aSource.Play();
    }*/

    void Idle()
    {

    }

    void Attack()
    {
        //벽이 무너진다면 idle 상태로 전환
        if (WallOnDamage2.wallDamage2.hp <= 0)
        {
            enemyState = EnemyState.Idle;
            print("공격할게 없어");
        }

        else
        {
            if (currentTime >= attackDelayTime)
            {
                currentTime = 0;

                print("공격!");
                WallOnDamage2 wd2 = wall.GetComponent<WallOnDamage2>();
                wd2.wallOnDamage2(attackPower);

                fireEffect.transform.position = firePosition.position;
                ps.Play();
                aSource.Play();
            }
            else
            {
                currentTime += Time.deltaTime;
            }
        }
    }

    void AttackDelay()
    {

    }

    void Damaged()
    {
        //코루틴 함수 실행
        StartCoroutine(DamageProcess());
    }

    IEnumerator DamageProcess()
    {
        //1초간 정지
        yield return new WaitForSeconds(1.0f);
        print("아직 아파");

        //attack 상태로 전환
        enemyState = EnemyState.Attack;
        print("damage -> attack");
    }

    void Die()
    {
        StartCoroutine(DieProcess());
    }
    IEnumerator DieProcess()
    {
        //1초간 기다렸다가 죽은 모습으로 전환
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
        enemyDead.SetActive(true);
    }
    //데미지 처리 함수
    public void HitEnemy(int value)
    {
        currentHp -= value;

        //hp > 0이면 damaged 상태로 전환
        if (currentHp > 0)
        {
            enemyState = EnemyState.Damaged;
            print("아야!!");
            Damaged();
        }
        //hp <= 0이면 die 상태로 전환
        else
        {
            enemyState = EnemyState.Die;
            print("죽음...");
            /*PlaySound("enemyDie");*/
            dyingEffect.transform.position = explodePositon.position;
            ps1.Play();
            Die();
        }
    }
}
