using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniEnemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;

    void Update()
    {
        dir = Vector3.up;
        transform.position += dir * speed * Time.deltaTime;
    }
}
