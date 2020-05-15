using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCat : MonoBehaviour
{
    public float loopTime = 1f;
    // Update is called once per frame

    private float loopTimer = 0f;

    void Update()
    {
        loopTimer += Time.deltaTime;

        if (loopTimer >= loopTime){
            loopTimer = 0f;
            Vector3 scale = transform.localScale;
            scale.x = -scale.x;
            transform.localScale = scale;
        }
        
    }
}
