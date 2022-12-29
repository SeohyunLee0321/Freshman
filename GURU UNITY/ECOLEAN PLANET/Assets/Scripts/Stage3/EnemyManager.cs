using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager enemymanager = null;
    //적 생성 시간 변수
    float createTime;

    //경과 시간 변수
    float currentTime; 

    //적 공장 변수
    public GameObject enemyFactory;

    //최소, 최대 시간 변수
    public float minTime = 1;
    public float maxTime = 5;

    public int MENum = 0;
    [HideInInspector]

    public int LDNum = 0;

    //오브젝트풀 크기, 오브젝트풀, SpawnPoint 담을 변수
    public static List<GameObject> enemyObjectPool;
    public Transform[] spawnPoints;

    private void Awake()
    {
        if (enemymanager == null)
        {
            enemymanager = this;
        }
    }

    void Start()
    {
        //태어날 때 적 생성시간 설정
        createTime = Random.Range(minTime, maxTime);

        //에너미 오브젝트풀 생성 및 관리
        enemyObjectPool = new List<GameObject>();

        //반복해서 생성
        for (int i = 0; i < 25; i++)
        {
            //3. enemy 공장에서 enemy 만들기
            GameObject enemy = Instantiate(enemyFactory);
            //4. enemy 오브젝트풀에 넣기
            enemyObjectPool.Add(enemy);
            //비활성화
            enemy.SetActive(false);
        }
    }

    void Update()
    {
        //경과 시간 흐름
        currentTime += Time.deltaTime;

        //만약 경과시간이 생성시간 초과 시
        if (currentTime > createTime)
        {
            //오브젝트풀에서 enemy를 가져다 사용
            if (enemyObjectPool.Count > 0)
            {
                GameObject enemy = enemyObjectPool[0];
                enemy.SetActive(true);

                MENum++;
                if(MENum - 5 == 0)
                {
                    GameObject.Find("Directional Light").GetComponent<SkyLD>().LightDown();
                    LDNum++;
                    MENum = 0;
                }

                enemyObjectPool.RemoveAt(0);

                //랜덤으로 spawnpoints 중에서 하나 선택해 배치
                int index = Random.Range(0, spawnPoints.Length);
                enemy.transform.position = spawnPoints[index].position;
            }

            //경과 시간 초기화
            currentTime = 0;

            createTime = Random.Range(minTime, maxTime);
        }
    }
}

