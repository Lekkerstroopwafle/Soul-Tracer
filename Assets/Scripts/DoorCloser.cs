using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloser : MonoBehaviour
{
    public DoorScript doorScript;

    public void OnTriggerEnter(Collider other)
    {
        doorScript.triggered = false;
    }
}
