using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    public bool touchingGround = false;
    private void OnTriggerEnter2D(Collider2D otherCollider){
        if ("ground".Equals(otherCollider.tag)){
            touchingGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider){
        if ("ground".Equals(otherCollider.tag)){
            touchingGround = false;
        }
    }

}
