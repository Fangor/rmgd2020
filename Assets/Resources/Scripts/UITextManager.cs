using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextManager : Singleton<UITextManager>
{

    // public TextMeshProUGUI waveText;
    // public TextMeshProUGUI startWaveText;
    // public TextMeshProUGUI startWaveDescText;
    // public TextMeshProUGUI enemiesLeftText;

    public TextMeshProUGUI player1JoinStatus;
    public TextMeshProUGUI player2JoinStatus;

    public TextMeshProUGUI pressStartText;
    public float totalAnimationTime = 3;

    // This is the overlay that tells the player that the game is over
    // public GameObject GameOverPanel;

    public void Start()
    {
        // GameOverPanel.SetActive(false);
    }

    protected override void Awake()
    {
        base.Awake();
        // SetWave(1);
    }

    public void Player1Joined(){
        player1JoinStatus.text = "Player 1 Ready";
    }

    public void Player2Joined(){
        player2JoinStatus.text = "Player 2 Ready";
    }

    public void DisplayReadyText(){
        pressStartText.text = "Press Start to begin";
    }

    public void SetWave(int wave)
    {
        // waveText.text = "Wave " + wave + " of 10";
        // DoStartWaveAnimation(wave);

        // switch(wave)
        // {
        //     case 1:
        //         startWaveDescText.text = "Kill adventurers and defend your treasure";
        //         break;
        //     case 2:
        //         startWaveDescText.text = "Your treasure is your lifeblood, don't let it go";
        //         break;
        //     case 3:
        //         startWaveDescText.text = "They're after your gold...";
        //         break;
        //     case 4:
        //         startWaveDescText.text = "You're after their blood...";
        //         break;
        //     case 5:
        //         startWaveDescText.text = "It's starting to get crowded in here";
        //         break;
        //     case 6:
        //         startWaveDescText.text = "I'd buy that for a dollar";
        //         break;
        //     case 7:
        //         startWaveDescText.text = "Big money, big prizes, I love it!";
        //         break;
        //     case 8:
        //         startWaveDescText.text = "The wheel of fate is turning...";
        //         break;
        //     case 9:
        //         startWaveDescText.text = "Decide the destiny!";
        //         break;
        //     case 10:
        //         startWaveDescText.text = "Can't escape from crossing fate!!";
        //         break;
        // }
    }

    public void DoStartWaveAnimation(int wave)
    {
        // startWaveText.text = "-Wave " + wave + "-";
        // StartCoroutine("StartWaveTextCR");
    }

    // IEnumerator StartWaveTextCR()
    // {
    //     // float timeToAnimate = 0;
    //     // while (timeToAnimate < totalAnimationTime)
    //     // {
    //     //     timeToAnimate += Time.deltaTime;
    //     //     startWaveText.color = new Color(startWaveText.color.r, startWaveText.color.g, startWaveText.color.b, totalAnimationTime - timeToAnimate);
    //     //     startWaveDescText.color = new Color(startWaveDescText.color.r, startWaveDescText.color.g, startWaveDescText.color.b, totalAnimationTime - timeToAnimate);
    //     //     yield return null;
    //     // }
    // }

    public void SetEnemiesLeft(int wave)
    {
        // enemiesLeftText.text = wave + " enemies left";
    }

    // This method is remotely triggered when a Game Over is assessed
    // by the GameManager
    public void OnGameOver()
    {
        // GameOverPanel.SetActive(true);
    }
}
