using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    //���� �¿� �Է� �޾Ƽ� ����(����)���� �̵�
    //1.�ӷ�
    //2.����

    //ĳ���Ϳ��� �߷�(����)�� �����ϰ�ʹ�

    //�߷� ����
    public float gravity = -20.0f;

    //������
    public float jumpPower = 10.0f;

    //�ִ� ���� Ƚ��
    public int maxJump = 2;

    //���� ���� Ƚ��
    int jumpCount = 0;

    //���� �ӵ� ����
    float yVelocity = 0;

    //�ӷº���
    public float moveSpeed = 7.0f;

    //ĳ���� ��Ʈ�ѷ� ����
    CharacterController cc;

    //ü�� ����
    public int hp;

    //�ִ� ü��
    public int maxHp = 10;

    //�����̴� UI
    public Slider hpSlider;

    //����Ʈ UI ������Ʈ
    public GameObject hitEffect;

    //�ִϸ����� ������Ʈ ����
    Animator anim;

    void Start()
    {
        //ĳ���� ��Ʈ�ѷ� ������Ʈ�� �޾ƿ´�
        cc = GetComponent<CharacterController>();

        //ü�� ���� �ʱ�ȭ
        hp = maxHp;

        //�ڽ� ������Ʈ�� �ִϸ����� ������Ʈ�� �����°�
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        //�����̴��� value�� ü�� ������ ����
        hpSlider.value = (float)hp / (float)maxHp;

        //���� ���°� ���� �� ���°� �ƴϸ� ������Ʈ �Լ��� ����
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //�̵� ���� ����
        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();

        //�̵� ���� ������ ũ�� ���� �ִϸ������� �̵� ���� Ʈ���� ����
        anim.SetFloat("MoveDirection", dir.magnitude);

        //�̵� ������ ī�޶� ���� �������� ��ȯ(���� -> ����)
        dir = Camera.main.transform.TransformDirection(dir);

        //�÷��̾ ���� �����ϸ� ���� ���� Ƚ���� 0���� �ʱ�ȭ
        //���� �ӵ� ��(�߷�)�� 0���� �ʱ�ȭ
        if(cc.collisionFlags == CollisionFlags.Below)
        {
            jumpCount = 0;
            yVelocity = 0;
        }

        //����Ű�� ������, �������� ���� �ӵ��� ����
        //��, ���� ���� Ƚ���� �ִ� ���� Ƚ���� �ʰ����� �ʾƾ� ��
        if(Input.GetButtonDown("Jump") && jumpCount < maxJump)
        {
            jumpCount++;
            yVelocity = jumpPower;
        }

        //ĳ������ �����ӵ�(�߷�)�� ����
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //�̵� �������� �÷��̾� �̵�
        //P = P0 + VT
        //transform.position += dir * moveSpeed * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }

    //�÷��̾� �ǰ� �Լ�
    public void OnDamage(int value)
    {
        hp -= value;
        if(hp < 0)
        {
            hp = 0;
        }
        //hp�� 0���� ū ��쿡�� �ǰ� ����Ʈ �ڷ�ƾ�� ����
        else
        {
            StartCoroutine(HitEffect());
        }
        
        IEnumerator HitEffect()
        {
            //1.����Ʈ Ȱ��ȭ
            hitEffect.SetActive(true);

            //2.0.3�� ��ٸ���
            yield return new WaitForSeconds(0.3f);

            //3.����Ʈ ��Ȱ��ȭ
            hitEffect.SetActive(false);
        }
    }
}
