using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInMouth : MonoBehaviour
{
    public void EnableBallInMouth(){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;

    }

    public void DisableBallInMouth(){
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;

    }
}
