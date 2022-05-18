using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersfxmuted : MonoBehaviour
{
    public AudioSource playSound;
    private AudioSource Audio;
    void OnTriggerEnter2D (Collider2D other)
    {
        Audio = GetComponent<AudioSource>();
        Audio.loop = true;
        playSound.Play();
      
    }
}
