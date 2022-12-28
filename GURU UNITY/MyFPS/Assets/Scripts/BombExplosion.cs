using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    //���� ȿ�� ������ ����
    public GameObject explosion;

    //���� �ݰ�
    public float explosionRadius = 5.0f;

    //����ź ������ ����
    public int bombPower = 3;

    private void OnCollisionEnter(Collision collision)
    {
        //���� �浹�Ѵٸ� ���� ȿ�� ����Ʈ�� �����Ѵ�
        GameObject go = Instantiate(explosion);
        go.transform.position = transform.position;

        //�ڽ��� ��ġ���� ������ �ݰ游ŭ �˻��ؼ� ���� �� ���ʹ̵��� ã�´�
        Collider[] enemies = Physics.OverlapSphere(transform.position, explosionRadius, 1 << 10);

        //����� ���ʹ̵鿡�� ����ź ������ ������
        for(int i = 0; i < enemies.Length; i++)
        {
            EnemyFSM eFSM = enemies[i].transform.GetComponent<EnemyFSM>();
            eFSM.HitEnemy(bombPower);
        }
        //�ڽ��� ����
        Destroy(gameObject);
    }
}
