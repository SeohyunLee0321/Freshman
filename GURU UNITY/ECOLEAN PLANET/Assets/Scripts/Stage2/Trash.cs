using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;

    void Update()
    {
        dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Trashcan") || other.gameObject.name.Contains("BG"))
        {
            Destroy(gameObject);
        }
    }
}