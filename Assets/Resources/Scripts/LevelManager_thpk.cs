using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_thpk : Singleton<LevelManager_thpk>
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
