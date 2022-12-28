using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    //ȸ�� �ӷ� ����
    public float rotSpeed = 300.0f;

    //ȸ�� ���� ����
    float mx = 0;

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

        //2.�Է¹��� �� �̿� ȸ�� ���� ����
        //Vector3 dir = new Vector3(0, mouse_X, 0);
        //dir.Normalize();
        mx += mouse_X * rotSpeed * Time.deltaTime;

        //3.������ ȸ�� ���� ȸ�� �Ӽ��� ����
        // R = R0 + VT
        //transform.eulerAngles += dir * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }
}
