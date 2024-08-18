using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    public GateRotateAnti gateAnti;
    public GateRotate gate;

    public void OnTriggerEnter()
    {
        gateAnti.triggered = true;
        gate.triggered = true;
    }
}
