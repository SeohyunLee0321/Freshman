using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    public static TrashManager trashM = null;
    //적 생성 시간 변수
    float createTime;

    //경과 시간 변수
    float currentTime;

    //쓰레기 공장 변수
    //public GameObject TrashFactory;

    //쓰레기 공장 배열
    public GameObject[] TrashFactory;

    //최소, 최대 시간 변수
    public float minTime = 1;
    public float maxTime = 5;

    public int TrashNum;
    [HideInInspector]

    //오브젝트풀 크기, 오브젝트풀, SpawnPoint 담을 변수
    public int poolSize = 45;
    public static List<GameObject> trashObjectPool;
    public Transform[] spawnPoints;

    private void Awake()
    {
        if (trashM == null)
        {
            trashM = this;
        }
    }

    void Start()
    {
        //적 생성시간 설정
        createTime = Random.Range(minTime, maxTime);

        TrashNum = 0;

        //쓰레기 오브젝트풀 생성 및 관리
        trashObjectPool = new List<GameObject>();

        //반복해서 오브젝트풀 크기만큼 만들기
        for (int i = 0; i < poolSize; i++)
        {
            //쓰레기 공장 쓰레기 제작
            GameObject trash = Instantiate(SelectTrash());

            //오브젝트풀에 넣기
            trashObjectPool.Add(trash);

            //비활성화 하기
            trash.SetActive(false);
        }
    }

    void Update()
    {
        //경과 시간 흐름
        currentTime += Time.deltaTime;

        //만약 경과시간이 생성시간 초과 시
        if (currentTime > createTime)
        {
            //오브젝트풀에서 쓰레기 활성화
            if (trashObjectPool.Count > 0)
            {
                GameObject trash = trashObjectPool[0];
                trash.SetActive(true);

                trashObjectPool.RemoveAt(0);

                //spawnpoints 중에서 랜덤으로 하나 선택해 배치
                int index = Random.Range(0, spawnPoints.Length);
                trash.transform.position = spawnPoints[index].position;

                TrashNum++;
            }

            //경과 시간 초기화
            currentTime = 0;

            createTime = Random.Range(minTime, maxTime);
        }
    }

    //쓰레기 종류 랜덤 선택 함수
    public GameObject SelectTrash()
    {
        //9개의 쓰레기 배열 중 랜덤하게 1개 고름
        int num = Random.Range(0, TrashFactory.Length - 1);

        return TrashFactory[num];
    }
}