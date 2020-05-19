using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextManager_thpk : Singleton<UITextManager_thpk>
{
    public TextMeshProUGUI player1JoinStatus;
    public TextMeshProUGUI player2JoinStatus;

    public TextMeshProUGUI pressStartText;

    public TextMeshProUGUI countdownText;

    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    public TextMeshProUGUI p1ComboBarText;
    public TextMeshProUGUI p2ComboBarText;

    public TextMeshProUGUI roundTimerText;
    public TextMeshProUGUI victoryText;

    public int countdownSeconds = 5;

    public GameObject titlePanel;
    public GameObject countdownPanel;
    public GameObject scorePanel;
    public GameObject victoryPanel;

    public void Start()
    {
        titlePanel.SetActive(true);
        countdownPanel.SetActive(false);
        scorePanel.SetActive(false);
        victoryPanel.SetActive(false);

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
        GameManager_thpk.instance.GotoMainGameState();
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

    public void UpdateComboBar(int PlayerNumber, List<string> combos){
        string comboText = "";
        foreach (string combo in combos){
            comboText += "\n" + combo;
        }
        if (PlayerNumber == 1){
            p1ComboBarText.text = comboText;
        }
        if (PlayerNumber == 2){
            p2ComboBarText.text = comboText;
        }
    }

    public void UpdateRoundTime(float roundTimer){
        int roundTimerCeiling = Mathf.CeilToInt(roundTimer);
        roundTimerText.text = "" + roundTimerCeiling;
    }

    public void DisplayVictoryText(string text){
        victoryText.text = text;
        victoryPanel.SetActive(true);
    }
}
