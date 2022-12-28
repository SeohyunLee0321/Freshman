using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    //���� ���� ���ʹ̰� ��Ȳ�� �´� �ൿ�ϰ� �ϰ� �ʹ�
    //1.���ʹ̻���
    //2.���º� �Լ�
    //3.switch�� ���ؼ� ���� üũ, ���º� �Լ� ����

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

    //�÷��̾� ���� ������Ʈ
    GameObject player;

    //���� ����
    public float findDistance = 8.0f;

    //���� ĳ���� ��Ʈ�ѷ�
    CharacterController cc;

    //�̵� �ӵ�
    public float moveSpeed = 5.0f;

    //���� ���� ����
    public float attackDistance = 2.0f;

    //���� ���� �ð� ����
    float currentTime = 0;

    //���� ������ �ð�
    public float attackDelayTime = 2.0f;

    //���ݷ� ����
    public int attackPower = 2;

    //�ʱ� ��ġ ȸ�� ����� ����
    Vector3 originPos;
    Quaternion originRot;

    //�̵� ������ �Ÿ�
    public float moveDistance = 20.0f;

    //�ִ� ü�� ����
    public int maxHp = 5;

    //���� ü�� ����
    int currentHp;

    //�����̴� ����
    public Slider hpSlider;

    //�ִϸ����� ������Ʈ ����
    Animator anim;

    //�׺���̼� �޽� ������Ʈ
    NavMeshAgent smith;

    void Start()
    {
        //�ʱ� ���´� ��� ����(Idle)
        enemyState = EnemyState.Idle;

        //�÷��̾� �˻�
        player = GameObject.Find("Player");

        //ĳ���� ��Ʈ�ѷ� �޾ƿ���
        cc = GetComponent<CharacterController>();

        //�ʱ� ��ġ�� ȸ�� �����ϱ�
        originPos = transform.position;
        originRot = transform.rotation;

        //���� ü�� ����
        currentHp = maxHp;

        //�ڽ� ������Ʈ�� �ִϸ����� ������Ʈ ��������
        anim = GetComponentInChildren<Animator>();

        //�׺�޽� ������Ʈ ������Ʈ ��������
        smith = GetComponent<NavMeshAgent>();
        smith.speed = moveSpeed;
        smith.stoppingDistance = attackDistance;
    }

    
    void Update()
    {
        //���� üũ�� ����ġ��
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

        //hp �����̴��� ���� ü�� ������ ����
        hpSlider.value = (float)currentHp / (float)maxHp;
    }

    //��� �ൿ �Լ�
    void Idle()
    {
        //�÷��̾���� �Ÿ��� ���� ���� �̳����...
        if (Vector3.Distance(player.transform.position, transform.position) <= findDistance)
        {
            //���¸� �̵� ���·� ����
            enemyState = EnemyState.Move;
            print("���� ��ȯ : Idle -> Move");
            anim.SetTrigger("IdleToMove");
        }
    }

    //�̵� �� �ൿ �Լ�
    void Move()
    {
        //�̵� �Ÿ� ���̶��...
        if (Vector3.Distance(originPos, transform.position) > moveDistance)
        {
            //���ͻ��·� ����
            enemyState = EnemyState.Return;
            print("���� ��ȯ : Move -> Return");
        }
        
        //���� ���� ���̶��...
        else if (Vector3.Distance(player.transform.position, transform.position) > attackDistance)
        {
            //�̵� ���� ���ϱ�
            //Vector3 dir = (player.transform.position - transform.position).normalized;

            //���� ���� ������ �̵� ����� ��ġ
            //transform.forward = dir;

            //ĳ���� ��Ʈ�ѷ��� �̵� �������� �̵�
            //cc.Move(dir * moveSpeed * Time.deltaTime);

            //����޽� ������Ʈ�� �̿��Ͽ� Ÿ�� �������� �̵�
            smith.SetDestination(player.transform.position);
            smith.stoppingDistance = attackDistance;
        }
        
        //���� ���� �ȿ� ������...
        else
        {
            //���¸� ���� ���·� ����
            enemyState = EnemyState.Attack;
            print("���� ��ȯ : Move -> Attack");

            anim.SetTrigger("MoveToAttackDelay");

            //���� ��� �ð� �̸� ����
            currentTime = attackDelayTime;

            //�̵� ���߰�, Ÿ�� �ʱ�ȭ
            smith.isStopped = true;
            smith.ResetPath();
        }
    }

    //���� �� �ൿ �Լ�
    void Attack()
    {
        //�÷��̾ ���� ���� �̳����...
        if (Vector3.Distance(player.transform.position, transform.position) <= attackDistance)
        {
            //���� ��� �ð��� ���� ��� �ð��� �ʰ��ߴٸ�...
            if (currentTime >= attackDelayTime)
            {
                currentTime = 0;

                //�÷��̾ ����
                print("����!");

                anim.SetTrigger("StartAttack");
            }
            else
            {
                //�ð� ����
                currentTime += Time.deltaTime;
            }
        }
        else
        {
            //���¸� �̵� ���·� ��ȯ
            enemyState = EnemyState.Move;
            print("���� ��ȯ : Attack -> Move");

            anim.SetTrigger("AttackToMove");
        }
    }

    //�÷��̾�� �������� �ִ� �Լ�
    public void HitEvent()
    {
        PlayerMove pm = player.GetComponent<PlayerMove>();
        pm.OnDamage(attackPower);
    }

    //���� �� �ൿ �Լ�
    void Return()
    {
        //���� ��ġ�� �������� �ʾҴٸ�, �� �������� �̵�
        if (Vector3.Distance(originPos, transform.position) > 0.1f)
        {
            //Vector3 dir = (originPos - transform.position).normalized;
            //transform.forward = dir;

            //cc.Move(dir * moveSpeed * Time.deltaTime);

            smith.SetDestination(originPos);
            smith.stoppingDistance = 0;
        }

        //���� ��ġ�� �����ϸ� ��� ���·� ��ȯ
        else
        {
            smith.isStopped = true;
            smith.ResetPath();

            transform.position = originPos;
            transform.rotation = originRot;

            enemyState = EnemyState.Idle;
            print("���� ��ȯ : Return -> Idle");
            anim.SetTrigger("MoveToIdle");

            //ü���� �ִ�ġ�� ȸ��
            currentHp = maxHp;
        }
    }

    //�ǰ� �� �ൿ �Լ�
    void Damaged()
    {
        //�ڷ�ƾ �Լ��� ����
        StartCoroutine(DamageProcess());
    }

    IEnumerator DamageProcess()
    {
        //2�ʰ� ����
        yield return new WaitForSeconds(2.0f);

        //���� �̵� ���·� ��ȯ
        enemyState = EnemyState.Move;
        print("���� ��ȯ : Damaged -> Move");
    }

    //��� �� �ൿ �Լ�
    void Die()
    {
        //������ ����� �ڷ�ƾ���� ��� ����
        StopAllCoroutines();

        //��� �ڷ�ƾ�� ����
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        //ĳ���� ��Ʈ�ѷ� ��Ȱ��ȭ
        cc.enabled = false;

        //2�ʰ� ��ٷȴٰ� ��ü ����
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }

    //������ ó�� �Լ�
    public void HitEnemy(int value)
    {
        //���� ���� ���°� �ǰ�, ����, ��� ������ ������ �Լ� ����
        if(enemyState == EnemyState.Damaged || enemyState == EnemyState.Return
            || enemyState == EnemyState.Die)
        {
            return;
        }
        
        currentHp -= value;

        //���� hp�� 0���� ũ�ٸ�...
        if (currentHp > 0)
        {
            //���¸� �ǰ� ���·� ��ȯ
            enemyState = EnemyState.Damaged;
            print("���� ��ȯ : Any state -> Damaged");
            anim.SetTrigger("Damaged");
            Damaged();
        }

        //hprk 0���϶��
        else
        {
            //���¸� ��� ���·� ��ȯ
            enemyState = EnemyState.Die;
            print("���� ��ȯ : Any state -> Die");
            anim.SetTrigger("Die");
            Die();
        }
    }
}
