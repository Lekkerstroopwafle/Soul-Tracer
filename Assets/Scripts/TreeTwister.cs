using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TreeTwister : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<TreeScript>() != null)
        {
            TreeScript tree = other.gameObject.GetComponent<TreeScript>();

            tree.TreeRandom();
        }
    }
}
