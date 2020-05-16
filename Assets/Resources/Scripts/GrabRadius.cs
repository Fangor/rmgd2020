using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRadius : MonoBehaviour
{
    private bool canReachToy = false;
    Collider2D toy = null;
    private void OnTriggerEnter2D(Collider2D otherCollider){
        if (otherCollider.tag == "toy"){
            canReachToy = true;
            toy = otherCollider;
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider){
        if (otherCollider.tag == "toy"){
            canReachToy = false;
            toy = null;
        }
    }

    public bool CanReachToy(){
        return canReachToy;
    }

    public Collider2D getToy(){
        return toy;
    }

}
