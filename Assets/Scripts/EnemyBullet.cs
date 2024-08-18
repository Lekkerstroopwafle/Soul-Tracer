using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
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

        // check if you hit the Player
        if (collision.gameObject.GetComponent<PlayerScript>() != null)
        {
            PlayerScript player = collision.gameObject.GetComponent<PlayerScript>();

            player.PlayerTakeDamage(damage);

            // destroy projectile
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
