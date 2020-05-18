using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInMouth : MonoBehaviour
{
    public void EnableBallInMouth(){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }

    public void DisableBallInMouth(){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;

    }
}
