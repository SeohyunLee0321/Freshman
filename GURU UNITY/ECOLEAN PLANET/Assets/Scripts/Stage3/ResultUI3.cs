using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultUI3 : MonoBehaviour
{
    public GameObject failUI;
    public GameObject successUI;

    void Start()
    {
        failUI.SetActive(false);
        successUI.SetActive(false);
    }

    void Update()
    {
        if (Enemy.enemyS.currentHp == 0 || EnemyManager.enemymanager.LDNum == 5)
        {
            if (Result3.result3.success == true)
            {
                successUI.SetActive(true);
                failUI.SetActive(false);
            }
            else
            {
                failUI.SetActive(true);
                successUI.SetActive(false);
            }
        }
    }
}
