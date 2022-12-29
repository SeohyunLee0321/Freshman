using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//부딪히는 물체 삭제
public class DestroyZone2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //쓰레기가 부딪히면 게임 오브젝트 삭제
        if (other.gameObject.name.Contains("Trash"))
        {
            Destroy(other);
        }
    }
}