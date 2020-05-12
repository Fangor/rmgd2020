using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        transform.Translate(moveX,moveY,0);


    }
}
