using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieEvents : MonoBehaviour
{
    AudioSource zombieAudio;
    void Start()
    {
        zombieAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider trigger) {
        Debug.Log(trigger.gameObject.name);
        if (trigger.gameObject.tag == "arañas") {
            zombieAudio.Play();
            Destroy(trigger.gameObject);
        }
    }
}
