using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //������ ��ġ�� ī�޶� ��ġ ����

    //�Ѿƴٴ� ��ġ ����
    public Transform followPosition;

    void Start()
    {
        
    }

    
    void Update()
    {
        //���� ��ġ�� followPosition�� ��ġ��Ŵ
        transform.position = followPosition.position;
    }
}
