using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

    public AudioClip dogBark;
    AudioSource audioSource;

	// Use this for initialization	
    void OnCollisonEnter2D (Collision2D collision)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = dogBark;
        audioSource.Play();
    }

}
