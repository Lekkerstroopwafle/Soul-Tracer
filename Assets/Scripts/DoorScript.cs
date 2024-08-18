using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true && transform.position.y < 46)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
      
        if (triggered == false && transform.position.y > 36.36)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
