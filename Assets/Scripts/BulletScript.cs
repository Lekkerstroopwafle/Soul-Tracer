using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int damage;

    private Rigidbody rb;

    private bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // make sure only to stick to the first target you hit
        if (targetHit)
            return;
        else
            targetHit = true;

        // check if you hit an enemy
        if (collision.gameObject.GetComponent<EnemyScript>() != null)
        {
            EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();

            enemy.TakeDamage(damage);

            // destroy projectile
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
