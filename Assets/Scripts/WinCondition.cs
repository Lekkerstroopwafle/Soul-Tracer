using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameManager gameManage;

    public void OnTriggerEnter(Collider other)
    {
        gameManage.playerWin = true;
    }
}
