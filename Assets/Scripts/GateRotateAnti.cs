using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRotateAnti : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotationTime;
    public bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        rotationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true && rotationTime < 1.6f)
        {
            rotationTime += Time.deltaTime;
            transform.Rotate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
