using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{


    public GameObject level;

    void Start()
    {
        level = GameObject.Find("Level");
        level.SetActive(false);
    }

    protected override void Awake(){
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearPen(){
        GameObject startingPen = GameObject.Find("Starting Pen");
        startingPen.SetActive(false);

        level.SetActive(true);

    }


}
