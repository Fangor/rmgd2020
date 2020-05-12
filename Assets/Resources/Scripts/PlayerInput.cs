using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public float speed = 1f;
    public int playerNumber = 1;

    // Update is called once per frame
    void Update()
    {
        string verticalAxisName = "P" + playerNumber + "_Vertical";
        string horizontalAxisName = "P" + playerNumber + "_Horizontal";


        float moveY = Input.GetAxis(verticalAxisName) * Time.deltaTime * speed;
        float moveX = Input.GetAxis(horizontalAxisName) * Time.deltaTime * speed;

        transform.Translate(moveX,moveY,0);


    }
}
