using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    public bool touchingGround = false;
    private void OnTriggerEnter(Collider otherCollider){
        if ("ground".Equals(otherCollider.tag)){
            touchingGround = true;
        }
    }

    private void OnTriggerExit(Collider otherCollider){
        touchingGround = false;
    }
}
