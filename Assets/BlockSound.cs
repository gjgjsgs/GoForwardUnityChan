using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {

    

    public AudioClip sound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Cube")
        {
            audioSource.PlayOneShot(sound);

        }


    }
}
