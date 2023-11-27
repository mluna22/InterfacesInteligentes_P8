using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speakers : MonoBehaviour
{
    bool microActivated;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            audioSource.clip = Microphone.Start("", true, 10, 44100);
        }
        if (Input.GetKeyUp(KeyCode.R)) {
            Microphone.End("");
            audioSource.Play();
        }
    }
}
