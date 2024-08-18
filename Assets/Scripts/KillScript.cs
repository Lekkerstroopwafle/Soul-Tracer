using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public PlayerScript playerScript;

    public void OnTriggerEnter(Collider other)
    {
        playerScript.currentHealth = 0;
    }
}
