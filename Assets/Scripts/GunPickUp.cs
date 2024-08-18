using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public GameObject gun;
    public GameObject gunInHand;

    public GameObject crossHair;
    public GameObject bulletCount;

    public void OnTriggerEnter(Collider other)
    {
        gun.SetActive(false);
        gunInHand.SetActive(true);
        crossHair.SetActive(true);
        bulletCount.SetActive(true);
    }
    
}
