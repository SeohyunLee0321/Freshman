using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result3 : MonoBehaviour
{
    public static Result3 result3;

    public bool success;

    void Start()
    {
        result3 = this;
    }

    void Update()
    {
        if (Enemy.enemyS.currentHp == 0 || EnemyManager.enemymanager.LDNum == 5)
        {
                if (Enemy.enemyS.currentHp == 0)
                {
                    success = true;
                }
                else if (EnemyManager.enemymanager.LDNum == 5)
                {
                    success = false;
                }
        }
    }
}

