using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerIdle : MonoBehaviour
{
    public AudioPlayer source;

    public void OnTriggerEnter()
    {
        source.PlayerIdle();
    }
}
