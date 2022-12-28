using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    //���콺 ��Ŭ����, �ü� �������� ����ź �߻�
    //�ʿ��� : �߻���ġ, �߻��� ��, ����ź ������Ʈ

    //����ź ������Ʈ
    public GameObject bombFactory;

    //�߻� ��ġ
    public Transform firePosition;

    //�߻��� ��
    public float throwPower = 10.0f;

    //�Ѿ� ����Ʈ ���� ������Ʈ
    public GameObject bulletEffect;

    //��ƼŬ �ý��� ����
    ParticleSystem ps;

    //����� �ҽ� ������Ʈ ����
    AudioSource aSource;

    //�Ѿ� ���ݷ�
    public int attackPower = 2;

    //�ִϸ����� ������Ʈ
    Animator anim;

    //���� ������ ��������Ʈ ����
    public GameObject weapon01;
    public GameObject weapon02;

    //ũ�ν���� ��������Ʈ ����
    public GameObject crosshair01;
    public GameObject crosshair02;

    //���콺 ������ ��ư Ŭ�� �� ��������Ʈ ����
    public GameObject weapon01_R;
    public GameObject weapon02_R;

    //���콺 ������ ��ư Ŭ�� �ܸ�� ��������Ʈ ����
    public GameObject crosshair02_zoom;

    //���� ��� ���
    enum WeaponMode
    {
        Normal,
        Sniper
    }

    WeaponMode wMode;

    //ī�޶� ���� �� �ƿ� üũ ���� ����
    bool isZoom = false;

    //���� ��� �ؽ�Ʈ
    public Text weaponText;

    //�ѱ� ����Ʈ �迭
    public GameObject[] eff_Flash;

    void Start()
    {
        //��ƼŬ �ý��� ������Ʈ ��������
        ps = bulletEffect.GetComponent<ParticleSystem>();

        //����� �ҽ� ������Ʈ ��������
        aSource = GetComponent<AudioSource>();

        //�ڽ� ������Ʈ���� �ִϸ����� ��������
        anim = GetComponentInChildren<Animator>();

        //�ʱ� ���� ���� �Ϲ� ���
        wMode = WeaponMode.Normal;
        weaponText.text = "Normal";
    }

    
    void Update()
    {
        //���� ���°� ���� �� ���°� �ƴϸ� ������Ʈ �Լ��� ����
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        //���콺 ��Ŭ����...
        if (Input.GetMouseButtonDown(0))
        {
            //1.���� ����
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            //2.���̿� �ε��� ����� ���� ���� ����
            RaycastHit hitinfo = new RaycastHit();

            //3.���̸� �߻��ؼ� �ε��� ����� �ִٸ�...
            if(Physics.Raycast(ray, out hitinfo))
            {
                //�ε��� ����� �̸� �ܼ�â�� ���
                //print(hitinfo.transform.name);

                //�ε��� ����� ���̾ Enemy���,
                if(hitinfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    EnemyFSM eFSM = hitinfo.transform.GetComponent<EnemyFSM>();
                    eFSM.HitEnemy(attackPower);
                }

                //�ε��� ��ġ�� �Ѿ� ����Ʈ ������Ʈ ��ġ
                bulletEffect.transform.position = hitinfo.point;

                //�Ѿ� ����Ʈ�� ������ �ε��� ������Ʈ�� ���� ����(��� ����)�� ��ġ��Ű��
                bulletEffect.transform.forward = hitinfo.normal;

                //�Ѿ� ����Ʈ �÷���
                ps.Play();
            }

            //�� �Ҹ��� �÷���
            aSource.Play();

            //���� Ʈ���� MoveDirection �Ķ���� ���� 0�϶�...
            if (anim.GetFloat("MoveDirection") == 0)
            {
                //�� �߻� �ִϸ��̼� �÷���
                anim.SetTrigger("Attack");
            }

            //�ѱ� ����Ʈ �ڷ�ƾ �Լ� ����
            StartCoroutine(ShootEffect(0.1f));
        }
        //���콺 ��Ŭ����...
        if(Input.GetMouseButtonDown(1))
        {
            //���� ��尡 �븻 �����, ����ź ��ô
            //���� ��尡 �������� �����, ī�޶� ���� �ܾƿ�
            switch(wMode)
            {
                case WeaponMode.Normal:
                    
                    //����ź ����
                    GameObject bomb = Instantiate(bombFactory);
                    bomb.transform.position = firePosition.position;

                    //����ź�� ������ٵ� ������Ʈ�� �޾ƿ���
                    Rigidbody rb = bomb.GetComponent<Rigidbody>();

                    //�ü� �������� �߻�
                    rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
                    
                    break;
                
                case WeaponMode.Sniper:
                    //�� �ƿ� ���¶��...
                    //�� �� ���·� �����, ī�޶��� �þ߰�(FoY)�� 15���� ����
                    if(!isZoom)
                    {
                        isZoom = true;
                        Camera.main.fieldOfView = 15.0f;

                        //�ܸ���϶� ũ�ν���� ����
                        crosshair02_zoom.SetActive(true);
                        crosshair02.SetActive(false);
                    }

                    //�׷��� �ʴٸ�...(����)
                    //�� �ƿ� ���·� �����, ī�޶��� �þ߰�(FoV)�� 60���� ����
                    else
                    {
                        isZoom = false;
                        Camera.main.fieldOfView = 60.0f;

                        //ũ�ν��� ������������ ��������
                        crosshair02_zoom.SetActive(false);
                        crosshair02.SetActive(true);
                    }
                    break;
            }
        }

        //���� Ű �Է��� 1���̸� ��� ���, 2���̸� �������� ���� ��ȯ
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Normal;
            weaponText.text = "Normal Mode";
            //�� �ƿ� ���·� ��ȯ
            Camera.main.fieldOfView = 60.0f;

            //1�� ��������Ʈ Ȱ��ȭ, 2�� ��������Ʈ ��Ȱ��ȭ
            weapon01.SetActive(true);
            weapon02.SetActive(false);
            crosshair01.SetActive(true);
            crosshair02.SetActive(false);

            //weapon01_R�� Ȱ��ȭ, weapon02_R�� ��Ȱ��ȭ
            weapon01_R.SetActive(true);
            weapon02_R.SetActive(false);

            //�������� ��忡�� �Ϲ� ��� Ű�� ��������
            //weapon01_R_zoom ��Ȱ��ȭ, �ܸ�� ����
            crosshair02_zoom.SetActive(false);

            isZoom = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Sniper;
            weaponText.text = "Sniper Mode";

            //1�� ��������Ʈ ��Ȱ��ȭ, 2�� ��������Ʈ Ȱ��ȭ
            weapon01.SetActive(false);
            weapon02.SetActive(true);
            crosshair01.SetActive(false);
            crosshair02.SetActive(true);

            //weapon01_R�� ��Ȱ��ȭ, weapon02_R�� Ȱ��ȭ
            weapon01_R.SetActive(false);
            weapon02_R.SetActive(true);
        }
    }
    //�ѱ� ����Ʈ �ڷ�ƾ �Լ�
    IEnumerator ShootEffect(float duration)
    {
        //�ټ����� ����Ʈ ������Ʈ �� �����ϰ� 1�� ����
        int num = Random.Range(0, eff_Flash.Length - 1);

        //���õ� ������Ʈ Ȱ��ȭ
        eff_Flash[num].SetActive(true);

        //���� �ð� (duration)���� ��ٸ���
        yield return new WaitForSeconds(duration);

        //Ȱ��ȭ�� ������Ʈ ��Ȱ��ȭ
        eff_Flash[num].SetActive(false);
    }
}
