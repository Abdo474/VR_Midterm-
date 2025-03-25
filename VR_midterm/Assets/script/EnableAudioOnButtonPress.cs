using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAudioOnButtonPress : MonoBehaviour
{
    public AudioSource audioSource; // Assign your AudioSource in the Inspector

    public void EnableAudio()
    {
        if (audioSource != null)
        {
            audioSource.enabled = true;
            audioSource.Play();
        }
    }
}
