using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    //����� �ð� ����
    float currentTime = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        //���� �� 2�� ������ �������
        if(currentTime >= 2)
        {
            Destroy(gameObject);
        }
        currentTime += Time.deltaTime;
    }
}
