using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public void EnableSlash(){
        gameObject.SetActive(true);

    }

    public void DisableSlash(){
        gameObject.SetActive(false);

    }
}
