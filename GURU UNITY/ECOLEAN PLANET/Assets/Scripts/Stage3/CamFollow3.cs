using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow3 : MonoBehaviour
{
    public Transform followPosition;

    void Update()
    {
        //나의 위치 = followPosition 위치
        transform.position = followPosition.position;
    }
}