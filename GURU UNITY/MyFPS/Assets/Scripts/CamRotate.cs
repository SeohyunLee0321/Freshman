using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //ȸ�� �ӷ� ����
    public float rotSpeed = 300.0f;

    //ȸ�� ���� ����
    public float rotLimit = 60.0f;

    //ȸ�� ���� ����
    float mx = 0;
    float my = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        //���� ���°� ���� �� ���°� �ƴϸ� ������Ʈ �Լ��� ����
        if (GameManager.gm.gState != GameManager.GameState.Run)
        {
            return;
        }

        //����� ���콺 �Է� -> ��ü �����¿�� ȸ��
        //1.������� ���콺 �Է�
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        my = Mathf.Clamp(my, -rotLimit, rotLimit);

        //2.�Է¹��� �� �̿� ȸ�� ���� ����
        /*Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);
        dir.Normalize();*/

        //3.������ ȸ�� ���� ȸ�� �Ӽ��� ����
        // R = R0 + VT
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(-my, mx, 0);

        //4.ȸ�� �� �� x�� ���� -90 ~ 90�� ���̷� ����
        /*Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90.0f, 90.0f);
        transform.eulerAngles = rot;*/
    }
}
