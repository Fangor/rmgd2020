using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public bool isFacingRight = true;

    public float knockbackY = .5f;
    public float knockbackX = 1f;
    public void EnableSlash(){
        gameObject.SetActive(true);

    }

    public void DisableSlash(){
        gameObject.SetActive(false);

    }

    public void OnTriggerEnter2D(Collider2D otherCollider){
        if ("player" == otherCollider.tag){
            PlayerController playerController = otherCollider.GetComponent<PlayerController>();
            
            Vector2 knockback;
            if (isFacingRight){
                knockback = new Vector2(knockbackX, knockbackY);
                //nudge the other player slightly to prevent friction interference
                Vector2 nudge = new Vector2(.001f, .001f);
                playerController.transform.Translate(nudge);
            } else{
                knockback = new Vector2(-knockbackX, knockbackY);
                Vector2 nudge = new Vector2(-.001f, .001f);
                playerController.transform.Translate(nudge);
            }
            playerController.rb.AddForce(knockback,ForceMode2D.Impulse);
        }
    }
}
