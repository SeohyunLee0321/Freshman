using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result1CamMove : MonoBehaviour
{
    public GameObject target;

    public float cameraSpeed;
    private Vector3 targetPosition;

    private void Start()
    {

    }

    void Update()
    {
        if (target.gameObject != null)
        {
            // target 위치 찾기
            targetPosition.Set(target.transform.position.x, target.transform.position.y, target.transform.position.z);

            // target 위치로 카메라 속도에 맞게 이동
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, cameraSpeed);
        }
    }
}
