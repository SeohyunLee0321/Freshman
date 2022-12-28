using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    void Update()
    {
        //메인 카메라의 전방 방향과 나의 전방 방향 일치시킴
        transform.forward = Camera.main.transform.forward;
    }
}
