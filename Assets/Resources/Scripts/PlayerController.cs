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

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (isJumping){

            Debug.Log("isJumping");
            timeInAir += Time.deltaTime;
            if (timeInAir <= maxTimeToApplyJumpForce){
                rb.AddForce(Vector2.up * continuousJumpForce * Time.deltaTime, ForceMode2D.Force);
            }
            else{
                isJumping = false;
                timeInAir = 0f;
            }
            
        }
    }

    private void Move(){

        Vector2 movement = new Vector2(i_movement.x, i_movement.y).normalized * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnMove(InputValue value)
    {
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

    private void OnButtonSouthPress()
    {
        //Jump
        PlayerFeet playerFeet = GetComponentInChildren<PlayerFeet>();
        if (playerFeet.touchingGround){
            isJumping = true;
            timeInAir = 0f;
            rb.AddForce(Vector2.up * initialJumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnButtonSouthRelease()
    {
        //Jump
        isJumping = false;
    }

    private void OnButtonEast()
    {
        //Interact
    }
    private void OnButtonNorth()
    {
        //Purr
    }

    private void OnButtonWest()
    {
        //Meow
    }

    private void OnButtonStart()
    {
        if (GameManager.instance.currentState == GameState.PlayersReady)
        {
            GameManager.instance.GotoCountdownState();
            UITextManager.instance.DisplayCountdown();
        }
    }

}
