using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public int enemySpawnNumber;
    public int enemySpawned;
    public bool triggered;

    void Start()
    {
        enemySpawnNumber = 5;
        triggered = false;
    }

    void Update()
    {
        if( triggered == true && enemySpawned != enemySpawnNumber)
        {
            SpawnEnemy();
            enemySpawned += 1;
        }
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
    }
}
