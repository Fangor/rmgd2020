using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextManager : Singleton<UITextManager>
{
    public TextMeshProUGUI player1JoinStatus;
    public TextMeshProUGUI player2JoinStatus;

    public TextMeshProUGUI pressStartText;

    public TextMeshProUGUI countdownText;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    public int countdownSeconds = 5;

    public GameObject titlePanel;
    public GameObject countdownPanel;
    public GameObject scorePanel;

    public void Start()
    {
        titlePanel.SetActive(true);
        countdownPanel.SetActive(false);
        scorePanel.SetActive(false);

    }

    protected override void Awake()
    {
        base.Awake();
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

    public void DisplayCountdown(){
        titlePanel.SetActive(false);
        countdownPanel.SetActive(true);
        countdownText.text = "5";
        StartCoroutine("StartCountdownTextCR");
    }

    IEnumerator StartCountdownTextCR()
    {
        int currentCount = countdownSeconds;
        float timeToAnimate = 0f;
        float totalAnimationTime = 1f;
        while (currentCount >= 0)
        {
            timeToAnimate += Time.deltaTime;
            countdownText.color = new Color(countdownText.color.r, countdownText.color.g, countdownText.color.b, totalAnimationTime - timeToAnimate);
            //countdownText.color = new Color(countdownText.color.r, countdownText.color.g, countdownText.color.b, totalAnimationTime - timeToAnimate);

            if (timeToAnimate >= totalAnimationTime ){
                currentCount--;
                countdownText.text = "" + currentCount;
                timeToAnimate = 0f;
            }
            if (currentCount == 0){
                countdownText.text = "Play!";
                
            }
            yield return null;
            
        }
        GameManager.instance.GotoMainGameState();
    }

    public void DisplayScores(){
        countdownPanel.SetActive(false);
        scorePanel.SetActive(true);
    }

    public void UpdateScore(int PlayerNumber, int Score){
        string paddedScore = Score.ToString("D10");
        if (PlayerNumber == 1){
            p1ScoreText.text = "Score: " + paddedScore;
        }
        if (PlayerNumber == 2){
            p2ScoreText.text = "Score: " + paddedScore;
        }
        
    }
}
