using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip idle;
    public AudioClip fight;

    public void PlayerIdle()
    {
        source.PlayOneShot(idle);
    }

    public void PlayerFight()
    {
        source.Stop();
        source.PlayOneShot(fight);
    }
}
