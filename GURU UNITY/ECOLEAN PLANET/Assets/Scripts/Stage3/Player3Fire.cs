using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player3Fire : MonoBehaviour
{
    public static Player3Fire playerfire = null;

    AudioSource audioS;
    public AudioClip BFire;
    public AudioClip BCharge;

    //공기 방울 공격력
    public int AP = 1;

    //크로스헤어 변수
    public GameObject crosshair;

    public GameObject BFactory;

    public GameObject firePosition;

    public GameObject BubbleChargeInfo;
    public GameObject BubbleFullInfo;

    public GameObject FireEffect;
    ParticleSystem fe;

    public int poolSize = 5;
    [HideInInspector]
    public static List<GameObject> bubbleObjectPool = new List<GameObject>();

    private void Awake()
    {
        if (playerfire == null)
        {
            playerfire = this;
        }
    }

    void Start()
    {
        BubbleChargeInfo.SetActive(false);
        BubbleFullInfo.SetActive(false);
        audioS = gameObject.GetComponent<AudioSource>();
        fe = FireEffect.GetComponent<ParticleSystem>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bubble = Instantiate(BFactory);
            bubbleObjectPool.Add(bubble);
            bubble.SetActive(false);
        }
    }

    void Update()
    {
        //플레이어가 에너미 공격 시 에너미 hp 감소
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(BubbleFire());
        }
    }

    public void CBubble(GameObject obj)
    {
        StartCoroutine(chargeBubble(obj));
    }

    public IEnumerator chargeBubble(GameObject obj)
    {
        if (bubbleObjectPool.Count >= 0 )
        {
            if(bubbleObjectPool.Count < 5)
            {
                for (int x = 0; x < 1; x++)
                {
                    GameObject bubble = Instantiate(BFactory);
                    bubbleObjectPool.Add(bubble);
                    bubble.SetActive(false);
                    audioS.PlayOneShot(BCharge, 1);
                    obj.GetComponent<Trees>().BubbleTrue();
                }
                
            }        
            else if (bubbleObjectPool.Count == 5)
            {
                BubbleFullInfo.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                BubbleFullInfo.SetActive(false);
            }    
        }
        
        
    }

    public IEnumerator BubbleFire()
    {
        if (bubbleObjectPool.Count > 0)
        {
            GameObject bubble = bubbleObjectPool[0];
            bubbleObjectPool.RemoveAt(0);
            bubble.SetActive(true);
            bubble.transform.position = firePosition.transform.position;
            audioS.PlayOneShot(BFire, 1);

            //레이 생성
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            //레이에 부딪힌 대상 정보 저장할 변수
            RaycastHit hitInfo = new RaycastHit();

            //레이를 발사해서 부딪힌 대상이 있다면
            if (Physics.Raycast(ray, out hitInfo))
            {

                //만일 부딪힌 대상의 레이어가 MainEnemy라면
                if (hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy2"))
                {
                    Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
                    enemy.HitEnemy(AP);
                    FireEffect.transform.position = hitInfo.point;
                    FireEffect.transform.forward = hitInfo.normal;
                    fe.Play();
                }            }
            yield return new WaitForSeconds(5.0f);
            Destroy(bubble);
        }
        else if (bubbleObjectPool.Count == 0)
        {
            BubbleChargeInfo.SetActive(true);
            yield return new WaitForSeconds(1.0f);
            BubbleChargeInfo.SetActive(false);
        }
    }
}