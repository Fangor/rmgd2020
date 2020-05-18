﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treat : MonoBehaviour
{
    public void EnableTreat(){
        gameObject.SetActive(true);

    }

    public void DisableTreat(){
        gameObject.SetActive(false);

    }

    public void OnTriggerEnter2D(Collider2D otherCollider){
        if ("player" == otherCollider.tag){
            PlayerController playerController = otherCollider.GetComponent<PlayerController>();
            playerController.hasTreat = true;
            
            Destroy(gameObject);
        }
    }
}
