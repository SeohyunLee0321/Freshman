using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemySpawnPoint;
    public GameObject enemyFactory;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (enemySpawnPoint != null)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = enemySpawnPoint.transform.position;
        }
    }
}
