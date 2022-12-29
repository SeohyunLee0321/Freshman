using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashcanF : MonoBehaviour
{
    int DP = 1; //데미지 크기 변수
    AudioSource audioS;
    public AudioClip Correct;
    public AudioClip Wrong;

    public GameObject SEffect;
    ParticleSystem ps1;

    public GameObject WEffect;
    ParticleSystem ps2;

    void Start()
    {
        audioS = gameObject.GetComponent<AudioSource>();
        ps1 = SEffect.GetComponent<ParticleSystem>();
        ps2 = WEffect.GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //쓰레기통의 종류와 다른 쓰레기 충돌 시 피격 함수 실행
        if (other.gameObject.name.Contains("TrashF_0"))
        {
            ScoreManager.scoremanager.Score++;
            audioS.PlayOneShot(Correct, 1);
            SEffect.transform.position = other.transform.position;
            ps1.Play();
            Destroy(other);
        }
        else
        {
            GameObject.Find("Player").GetComponent<PlayerMove2>().HitPlayer(DP);
            audioS.PlayOneShot(Wrong, 1);
            WEffect.transform.position = other.transform.position;
            ps2.Play();
            Destroy(other);
        }
    }
}