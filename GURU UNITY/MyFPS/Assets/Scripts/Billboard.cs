using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    void Update()
    {
        //���� ī�޶��� ���� ����� ���� ���� ���� ��ġ��Ŵ
        transform.forward = Camera.main.transform.forward;
    }
}
