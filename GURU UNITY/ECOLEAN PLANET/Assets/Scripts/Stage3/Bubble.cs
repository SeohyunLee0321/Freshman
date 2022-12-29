using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    //속력 변수
    public float speed = 10;
    Vector3 dir;

    void Update()
    {
        //앞으로 계속 이동
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}