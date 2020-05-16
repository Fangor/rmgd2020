using System.Collections;
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

public class GameManager : Singleton<GameManager>
{

    //public bool gameStarted = false;
    //public bool startScreen = true;

    // Dictates the state of the game
    public GameState currentState
    { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.WaitingForPlayers;
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
        LevelManager.instance.ClearPen();
        UITextManager.instance.DisplayScores();
    }

    public void GotoVictoryState()
    {
        currentState = GameState.Victory;
    }
}
