using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleForward : MonoBehaviour
{
    public GameObject muzzleFlash;
    public float flashTime;
    public float flashUp;

    void Start()
    {
        flashTime = 1f;
        flashUp = 0.0f;
    }

    void Update()
    {
        muzzleFlash.SetActive(true);
        flashUp += Time.deltaTime;
    }

    public void MuzzleBloom()
    {
        if (flashUp > flashTime)
        {
            muzzleFlash.SetActive(false);
            flashUp = 0.0f;
        }
    }
}
