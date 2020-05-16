using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    public bool touchingGround = false;

    private HashSet<Collider2D> groundCollidersImTouching = new HashSet<Collider2D>();
    private void OnTriggerEnter2D(Collider2D otherCollider){
        if ("ground".Equals(otherCollider.tag)){
            touchingGround = true;
            groundCollidersImTouching.Add(otherCollider);
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider){
        if (groundCollidersImTouching.Contains(otherCollider)){
            groundCollidersImTouching.Remove(otherCollider);
        }
        if (groundCollidersImTouching.Count <= 0){
            touchingGround = false;
        }
    }

}
