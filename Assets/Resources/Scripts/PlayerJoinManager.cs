using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJoinManager : MonoBehaviour
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
            UITextManager.instance.Player1Joined();
        }
        if (playerNumber == 2){
            player2joined = true;
            UITextManager.instance.Player2Joined();
        }

        if (player1joined && player2joined){
            GameManager.instance.GotoReadyState();
            UITextManager.instance.DisplayReadyText();
        }
    }
}
