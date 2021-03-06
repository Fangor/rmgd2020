﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    WaitingForPlayers,
    PlayersReady,
    Countdown,
    MainGame,
    Victory 
}

public class GameManager_thpk : Singleton<GameManager_thpk>
{

    public float roundTimer = 99f;
    public float maxRoundTimer = 99;
    
    public PlayerController player1Controller = null;
    public PlayerController player2Controller = null;

    // Dictates the state of the game
    public GameState currentState
    { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.WaitingForPlayers;
    }

    void Update(){
        if (currentState == GameState.MainGame){
            roundTimer -= Time.deltaTime;
            UITextManager_thpk.instance.UpdateRoundTime(roundTimer);

        }
        if (roundTimer <= 0f){
            currentState = GameState.Victory;
            if (player1Controller.score > player2Controller.score){
                UITextManager_thpk.instance.DisplayVictoryText("Player 1 Wins!");
            }
            else if (player1Controller.score < player2Controller.score){
                UITextManager_thpk.instance.DisplayVictoryText("Player 2 Wins!");
            } else{
                UITextManager_thpk.instance.DisplayVictoryText("Draw!");
            }
        }
    }

    protected override void Awake()
    {
        base.Awake();
        // SetWave(1);
    }
    public void GotoReadyState()
    {
        currentState = GameState.PlayersReady;
    }

    public void GotoCountdownState()
    {
        currentState = GameState.Countdown;
    }

    public void GotoMainGameState()
    {
        currentState = GameState.MainGame;
        LevelManager_thpk.instance.ClearPen();
        UITextManager_thpk.instance.DisplayScores();
        roundTimer = maxRoundTimer;
        FishSpawnManager_thpk.instance.spawningEnabled=true;

    }

    public void GotoVictoryState()
    {
        currentState = GameState.Victory;
        FishSpawnManager_thpk.instance.spawningEnabled=false;
    }
}
