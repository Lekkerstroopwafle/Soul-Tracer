using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox;

    public void OnTriggerEnter(Collider other)
    {
        dialogueBox.SetActive(true);
    }
}
