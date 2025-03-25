using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToEnable; // Assign the empty GameObject in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectToEnable.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectToEnable.SetActive(false);
        }
    }
}

