using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire2 : MonoBehaviour
{
    public Transform firePosition;

    public GameObject bulletEffect;
    public GameObject fireEffect;
    ParticleSystem ps;
    ParticleSystem ps1;
    AudioSource aSource;

    public int attackPower = 1;

    private float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>();
        ps1 = fireEffect.GetComponent<ParticleSystem>();

        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitinfo = new RaycastHit();

            fireEffect.transform.position = firePosition.position;
            ps1.Play();

            if (Physics.Raycast(ray, out hitinfo))
            {
                if (hitinfo.transform.gameObject.layer == LayerMask.NameToLayer("Enemy2"))
                {
                    EnemyFSM2 eFSM2 = hitinfo.transform.GetComponent<EnemyFSM2>();
                    eFSM2.HitEnemy(attackPower);
                }

                bulletEffect.transform.position = hitinfo.point;
                bulletEffect.transform.forward = hitinfo.normal;
                ps.Play();
            }
            aSource.Play();
        }
    }
}
