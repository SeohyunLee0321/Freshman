using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{
    //공기 방울 있는 나무 게임 오브젝트
    public GameObject Bubbles;

    public GameObject ChargeInfo;

    void Start()
    {
        Bubbles.SetActive(true);
        ChargeInfo.SetActive(false);
    }

    //부딪힌 대상이 Player일 때 TreeBubbble 코루틴 함수 실행
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            if(Bubbles.activeSelf == true)
            {
                Player3Fire.playerfire.CBubble(gameObject);
            }            
            else
            {
            StartCoroutine(ChargeingInfo());
            }
        }
    }

    public IEnumerator ChargeingInfo()
    {
        ChargeInfo.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        ChargeInfo.SetActive(false);
    }

    public IEnumerator TreeBTrue()
    {
        Bubbles.SetActive(false);
        yield return new WaitForSeconds(10.0f);
        Bubbles.SetActive(true);
    }

    public void BubbleTrue()
    {
        StartCoroutine(TreeBTrue());
    }
}