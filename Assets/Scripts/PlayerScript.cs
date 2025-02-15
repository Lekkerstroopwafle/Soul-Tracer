using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameManager gameManage;
    public PlayerMovement playerMove;
    public PlayerCam playerCam;
    public GunSystem gunSys;
    public HealthBar healthBar;

    public int maxHealth;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            gameManage.playerAlive = false;
            playerMove.playerAlive = false;
            playerCam.playerAlive = false;
            gunSys.playerAlive = false;
        }
    }

    public void PlayerTakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
