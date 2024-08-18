using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public EnemySpawner enemySpawn;

    public void OnTriggerEnter(Collider other)
    {
        enemySpawn.triggered = true;
        gameObject.SetActive(false);
    }
}
