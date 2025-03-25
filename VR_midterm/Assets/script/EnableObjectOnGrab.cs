using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableObjectOnGrab : MonoBehaviour
{
    public XRGrabInteractable grabInteractable; // Assign the grab object in the Inspector
    public GameObject objectToEnable; // Assign the object to enable in the Inspector

    private void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(OnGrabbed);
        grabInteractable.selectExited.AddListener(OnReleased);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrabbed);
        grabInteractable.selectExited.RemoveListener(OnReleased);
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }
    }

    private void OnReleased(SelectExitEventArgs args)
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(false);
        }
    }
}


