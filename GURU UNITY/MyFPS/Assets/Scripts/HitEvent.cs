using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEvent : MonoBehaviour
{
    //���ʹ� FSM ������Ʈ ����
    public EnemyFSM eFSM;

    public void OnHit()
    {
        //�÷��̾�� ������ �ִ� �Լ� ����
        eFSM.HitEvent();
    }
}
