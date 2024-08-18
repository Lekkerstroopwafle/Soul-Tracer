using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTime : MonoBehaviour
{
    public float timeDeath;
    public float timeStart;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = 0f;
        timeDeath = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart > timeDeath)
        {
            Destroy(gameObject);
        }
    }
}
