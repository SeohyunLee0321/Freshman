using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDestroy : MonoBehaviour
{
    //경과된 시간 변수
    float currentTime = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        //생성 후 2초 지나면 사라진다
        if(currentTime >= 2)
        {
            Destroy(gameObject);
        }
        currentTime += Time.deltaTime;
    }
}
