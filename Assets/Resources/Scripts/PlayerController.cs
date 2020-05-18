using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 i_movement;
    public float moveSpeed = 3f;
    public float initialJumpForce = 150f;
    public float continuousJumpForce = 150f;
    private bool isJumping = false;
    public float maxTimeToApplyJumpForce = .5f;
    private float timeInAir = 0f;

    private bool hasToy = false;

    public Rigidbody2D ballPrefab;

    public float dropItemSpeed = 1f;


    public int score = 0;
    public int ballPointsPerSec = 100;
    public float highGroundLine = 0f;
    public int highGroundPointsPerSec = 30;

    private float pointTimer = 0f;

    public Rigidbody2D rb;
    private GrabRadius grabRadius;
    public int playerNumber = 1;

    public GameObject slash;
    public float slashTime = .2f;
    public float slashCooldown = .3f;
    private bool isSlashing = false;
    private bool isFacingRight = true;

    private bool isPurring = false;
    public GameObject purrEffect;
    public int purringPointsPerSec = 10;

    public bool hasTreat = false;
    public int treatPoints = 1000;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Awake(){
        grabRadius = GetComponentInChildren<GrabRadius>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (isJumping){

            timeInAir += Time.deltaTime;
            if (timeInAir <= maxTimeToApplyJumpForce){
                rb.AddForce(Vector2.up * continuousJumpForce * Time.deltaTime, ForceMode2D.Force);
            }
            else{
                isJumping = false;
                timeInAir = 0f;
            }
            
        }

        PlayerFeet playerFeet = GetComponentInChildren<PlayerFeet>();
        if (!playerFeet.touchingGround){
            isPurring = false;
            purrEffect.SetActive(false);
        }

        pointTimer += Time.deltaTime;
        List<string> comboList = new List<string>();
        if (pointTimer >= 1f){
            if (hasToy){
                score += ballPointsPerSec;
                comboList.Add("+" + ballPointsPerSec + "\tToy");
            }
            if (transform.position.y > 0f && playerFeet.touchingObstacle){
                score += highGroundPointsPerSec;
                comboList.Add("+" + highGroundPointsPerSec + "\tHigh Ground");
            }
            if (isPurring){
                score += purringPointsPerSec;
                comboList.Add("+" + purringPointsPerSec + "\tPurring");
            }
            if (hasTreat){
                score += treatPoints;
                hasTreat = false;
                comboList.Add("+" + treatPoints + "\tFish Treat");
            }


            UITextManager.instance.UpdateScore(playerNumber, score);
            UITextManager.instance.UpdateComboBar(playerNumber, comboList);
            pointTimer = 0f;
        }
    }

    private void Move(){

        Vector2 movement = new Vector2(i_movement.x, i_movement.y).normalized * moveSpeed * Time.deltaTime;
        if (i_movement.x > 0 && !isFacingRight){
            isFacingRight = true;
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        else if (i_movement.x < 0 && isFacingRight){
            isFacingRight = false;
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        transform.Translate(movement);
    }

    private void OnMove(InputValue value)
    {
        if (!isPurring){
            i_movement = value.Get<Vector2>();
            if (i_movement.x > 0f){
                i_movement.x = 1f;
            } else if (i_movement.x < 0f){
                i_movement.x = -1f;
            } else {
                i_movement.x = 0f;
            }
            i_movement.y = 0f;
        }
        else{
            i_movement = Vector2.zero;
        }
        
    }

    private void OnButtonSouthPress()
    {
        //Jump
        PlayerFeet playerFeet = GetComponentInChildren<PlayerFeet>();
        if (playerFeet.touchingGround){
            isJumping = true;
            timeInAir = 0f;
            rb.AddForce(Vector2.up * initialJumpForce, ForceMode2D.Impulse);
            playerFeet.PlayJumpSound();
        }
    }
    private void OnButtonSouthRelease()
    {
        //Jump
        isJumping = false;
    }

    private void OnButtonEastPress()
    {
        //Purr
        PlayerFeet playerFeet = GetComponentInChildren<PlayerFeet>();
        if (playerFeet.touchingGround){
            isPurring = true;
            purrEffect.SetActive(true);
        }
    }
    private void OnButtonEastRelease()
    {
        //Jump
        isPurring = false;
        purrEffect.SetActive(false);
    }
    private void OnButtonNorth()
    {
        //TBA
    }

    private void OnButtonWest()
    {
        //Attack/Grab/Release
        if (!hasToy && grabRadius.CanReachToy()){
            Collider2D toy = grabRadius.getToy();
            hasToy = true;
            BallInMouth ballInMouth = GetComponentInChildren<BallInMouth>();
            ballInMouth.EnableBallInMouth();
            Destroy(toy.gameObject);
        }
        else if (hasToy){
            Vector3 ballEjectPos = transform.position;
            ballEjectPos.y += .2f;
            Rigidbody2D ballRB = Instantiate(ballPrefab,ballEjectPos, transform.rotation);
            
            if (isFacingRight){
                ballRB.velocity = new Vector2(dropItemSpeed, dropItemSpeed);
            } else{
                ballRB.velocity = new Vector2(-dropItemSpeed, dropItemSpeed);
            }
            hasToy = false;
            BallInMouth ballInMouth = GetComponentInChildren<BallInMouth>();
            ballInMouth.DisableBallInMouth();
        }
        else {
            //attack
            if (isSlashing != true){
                slash.SetActive(true);
                Slash slashScript = slash.GetComponent<Slash>();
                slashScript.isFacingRight = isFacingRight;
                isSlashing = true;
                StartCoroutine("SlashAnimation");
            }
        }

    }

    public void DropToy(bool directionRight){
        if (hasToy){
            Vector3 ballEjectPos = transform.position;
            ballEjectPos.y += .2f;
            Rigidbody2D ballRB = Instantiate(ballPrefab,ballEjectPos, transform.rotation);
            
            if (directionRight){
                ballRB.velocity = new Vector2(dropItemSpeed, dropItemSpeed);
            } else{
                ballRB.velocity = new Vector2(-dropItemSpeed, dropItemSpeed);
            }
            hasToy = false;
            BallInMouth ballInMouth = GetComponentInChildren<BallInMouth>();
            ballInMouth.DisableBallInMouth();
        }
    }

        IEnumerator SlashAnimation()
    {
        float timeToAnimate = 0f;
        while (timeToAnimate <= slashTime)
        {
            timeToAnimate += Time.deltaTime;
            yield return null;
        }
        slash.SetActive(false);

        timeToAnimate = 0f;
        while (timeToAnimate <= slashCooldown)
        {
            timeToAnimate += Time.deltaTime;
            yield return null;
        }
        isSlashing = false;
    }

    private void OnButtonStart()
    {
        if (GameManager.instance.currentState == GameState.PlayersReady)
        {
            GameManager.instance.GotoCountdownState();
            UITextManager.instance.DisplayCountdown();
        }
    }

    public void PlayHurtSound(){
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }



}
