using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFire : MonoBehaviour
{
    //마우스 우클릭시, 시선 방향으로 수류탄 발사
    //필요요소 : 발사위치, 발사할 힘, 수류탄 오브젝트

    //수류탄 오브젝트
    public GameObject bombFactory;

    //발사 위치
    public Transform firePosition;

    //발사할 힘
    public float throwPower = 10.0f;

    //총알 이펙트 게임 오브젝트
    public GameObject bulletEffect;

    //파티클 시스템 변수
    ParticleSystem ps;

    //오디오 소스 컴포넌트 변수
    AudioSource aSource;

    //총알 공격력
    public int attackPower = 2;

    //애니메이터 컴포넌트
    Animator anim;

    //무기 아이콘 스프라이트 변수
    public GameObject weapon01;
    public GameObject weapon02;

    //크로스헤어 스프라이트 변수
    public GameObject crosshair01;
    public GameObject crosshair02;

    //마우스 오른쪽 버튼 클릭 시 스프라이트 변수
    public GameObject weapon01_R;
    public GameObject weapon02_R;

    //마우스 오른쪽 버튼 클릭 줌모드 스프라이트 변수
    public GameObject crosshair02_zoom;

    //게임 모드 상수
    enum WeaponMode
    {
        Normal,
        Sniper
    }

    WeaponMode wMode;

    //카메라 줌인 줌 아웃 체크 위한 변수
    bool isZoom = false;

    //무기 모드 텍스트
    public Text weaponText;

    //총구 이펙트 배열
    public GameObject[] eff_Flash;

    void Start()
    {
        //파티클 시스템 컴포넌트 가져오기
        ps = bulletEffect.GetComponent<ParticleSystem>();

        //오디오 소스 컴포넌트 가져오기
        aSource = GetComponent<AudioSource>();

        //자식 오브젝트에서 애니메이터 가져오기
        anim = GetComponentInChildren<Animator>();

        //초기 무기 모드는 일반 모드
        wMode = WeaponMode.Normal;
        weaponText.text = "Normal";
    }

    
    void Update()
    {
        //게임 상태가 게임 중 상태가 아니면 업데이트 함수를 종료
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        //마우스 좌클릭시...
        if (Input.GetMouseButtonDown(0))
        {
            //1.레이 생성
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            //2.레이에 부딪힌 대상의 정보 저장 변수
            RaycastHit hitinfo = new RaycastHit();

            //3.레이를 발사해서 부딪힌 대상이 있다면...
            if(Physics.Raycast(ray, out hitinfo))
            {
                //부딪힌 대상의 이름 콘솔창에 출력
                //print(hitinfo.transform.name);

                //부딪힌 대상의 레이어가 Enemy라면,
                if(hitinfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    EnemyFSM eFSM = hitinfo.transform.GetComponent<EnemyFSM>();
                    eFSM.HitEnemy(attackPower);
                }

                //부딪힌 위치에 총알 이펙트 오브젝트 위치
                bulletEffect.transform.position = hitinfo.point;

                //총알 이펙트의 방향을 부딪힌 오브젝트의 수직 방향(노멀 벡터)과 일치시키기
                bulletEffect.transform.forward = hitinfo.normal;

                //총알 이펙트 플레이
                ps.Play();
            }

            //총 소리를 플레이
            aSource.Play();

            //블렌드 트리의 MoveDirection 파라메터 값이 0일때...
            if (anim.GetFloat("MoveDirection") == 0)
            {
                //총 발사 애니메이션 플레이
                anim.SetTrigger("Attack");
            }

            //총구 이펙트 코루틴 함수 실행
            StartCoroutine(ShootEffect(0.1f));
        }
        //마우스 우클릭시...
        if(Input.GetMouseButtonDown(1))
        {
            //무기 모드가 노말 모드라면, 수류탄 투척
            //무기 모드가 스나이퍼 모드라면, 카메라 줌인 줌아웃
            switch(wMode)
            {
                case WeaponMode.Normal:
                    
                    //수류탄 생성
                    GameObject bomb = Instantiate(bombFactory);
                    bomb.transform.position = firePosition.position;

                    //수류탄의 리지드바디 컴포넌트를 받아오기
                    Rigidbody rb = bomb.GetComponent<Rigidbody>();

                    //시선 방향으로 발사
                    rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
                    
                    break;
                
                case WeaponMode.Sniper:
                    //줌 아웃 상태라면...
                    //줌 인 상태로 만들고, 카메라의 시야각(FoY)를 15도로 변경
                    if(!isZoom)
                    {
                        isZoom = true;
                        Camera.main.fieldOfView = 15.0f;

                        //줌모드일때 크로스헤어 변경
                        crosshair02_zoom.SetActive(true);
                        crosshair02.SetActive(false);
                    }

                    //그렇지 않다면...(줌인)
                    //줌 아웃 상태로 만들고, 카메라의 시야각(FoV)를 60도로 변경
                    else
                    {
                        isZoom = false;
                        Camera.main.fieldOfView = 60.0f;

                        //크로스헤어를 스나이프모드로 돌려놓기
                        crosshair02_zoom.SetActive(false);
                        crosshair02.SetActive(true);
                    }
                    break;
            }
        }

        //숫자 키 입력이 1번이면 노멀 모드, 2번이면 스나이퍼 모드로 전환
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            wMode = WeaponMode.Normal;
            weaponText.text = "Normal Mode";
            //줌 아웃 상태로 전환
            Camera.main.fieldOfView = 60.0f;

            //1번 스프라이트 활성화, 2번 스프라이트 비활성화
            weapon01.SetActive(true);
            weapon02.SetActive(false);
            crosshair01.SetActive(true);
            crosshair02.SetActive(false);

            //weapon01_R은 활성화, weapon02_R은 비활성화
            weapon01_R.SetActive(true);
            weapon02_R.SetActive(false);

            //스나이퍼 모드에서 일반 모드 키를 눌렀을때
            //weapon01_R_zoom 비활성화, 줌모드 해제
            crosshair02_zoom.SetActive(false);

            isZoom = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            wMode = WeaponMode.Sniper;
            weaponText.text = "Sniper Mode";

            //1번 스프라이트 비활성화, 2번 스프라이트 활성화
            weapon01.SetActive(false);
            weapon02.SetActive(true);
            crosshair01.SetActive(false);
            crosshair02.SetActive(true);

            //weapon01_R은 비활성화, weapon02_R은 활성화
            weapon01_R.SetActive(false);
            weapon02_R.SetActive(true);
        }
    }
    //총구 이펙트 코루틴 함수
    IEnumerator ShootEffect(float duration)
    {
        //다섯개의 이펙트 오브젝트 중 랜덤하게 1개 선택
        int num = Random.Range(0, eff_Flash.Length - 1);

        //선택된 오브젝트 활성화
        eff_Flash[num].SetActive(true);

        //일정 시간 (duration)동안 기다린다
        yield return new WaitForSeconds(duration);

        //활성화된 오브젝트 비활성화
        eff_Flash[num].SetActive(false);
    }
}
