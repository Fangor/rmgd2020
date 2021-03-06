﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJoinManager_thpk : MonoBehaviour
{
    private bool player1joined = false;
    private bool player2joined = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPlayerJoined(PlayerInput playerInput){

        uint playerNumber = playerInput.user.id;
        if (playerNumber == 1){
            player1joined = true;
            UITextManager_thpk.instance.Player1Joined();
            SpriteRenderer spriteRenderer = playerInput.GetComponentInParent<SpriteRenderer>();
            spriteRenderer.color = new Color(.5f, .5f, .5f, 1f);
            Transform transform = playerInput.GetComponentInParent<Transform>();
            transform.Translate(-1f, 0,0);

            PlayerController playerController = playerInput.GetComponentInParent<PlayerController>();
            GameManager_thpk.instance.player1Controller = playerController;
            playerController.playerNumber = 1;
        }
        if (playerNumber == 2){
            player2joined = true;
            UITextManager_thpk.instance.Player2Joined();
            Transform transform = playerInput.GetComponentInParent<Transform>();
            transform.Translate(1f, 0,0);

            PlayerController playerController = playerInput.GetComponentInParent<PlayerController>();
            GameManager_thpk.instance.player2Controller = playerController;
            playerController.playerNumber = 2;
        }

        if (player1joined && player2joined){
            GameManager_thpk.instance.GotoReadyState();
            UITextManager_thpk.instance.DisplayReadyText();
        }
    }
}
