using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerFight : MonoBehaviour
{
    public AudioPlayer source;

    public void OnTriggerEnter()
    {
        source.PlayerFight();
    }
}
