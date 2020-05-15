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
    VictoryScreen, 
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
        //SceneManager.LoadScene("VictoryScreen");
    }
    public void AssessTreasureCount(int inInt)
    {
        if (inInt < 1)
        {
            // If there's no money left on the field,
            // sets game state to Game Over and calls UI Text Manager
            // to turn on the GameOver UI panel.
            currentState = GameState.VictoryScreen;
            //UITextManager.instance.OnGameOver();
            //SceneManager.LoadScene("GameOverScreen");
        }
        else
        {
            currentState = GameState.MainGame;
        }
    }

    public void GotoVictoryScene()
    {
        //SceneManager.LoadScene("VictoryScreen");
    }
}
