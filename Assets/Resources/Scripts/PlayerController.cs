using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 i_movement;
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        Vector2 movement = new Vector2(i_movement.x, i_movement.y).normalized * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnMove(InputValue value)
    {
        i_movement = value.Get<Vector2>();
    }

    private void OnButtonSouth()
    {
        //Attack/defend
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
