using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotater : MonoBehaviour
{
    public float RotationSpeed = 6f;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * RotationSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * RotationSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
