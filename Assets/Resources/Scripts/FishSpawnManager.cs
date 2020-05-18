using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnManager : Singleton<FishSpawnManager>
{

    public GameObject fishSpawners;
    public GameObject fishPrefab;

    public float spawnIntervalInSecs = 10f;
    public float maxDistFromSpawner = 1f;

    public bool spawningEnabled = false;

    private float spawnTimer = 0f;

    private static System.Random rnd = new System.Random();
    private FishSpawner[] fishSpawnerArray;

    void Start()
    {
        
    }

    protected override void Awake(){
        base.Awake();

        fishSpawnerArray = fishSpawners.GetComponentsInChildren<FishSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawningEnabled && spawnTimer <= spawnIntervalInSecs){
            spawnTimer += Time.deltaTime;

        }
        else if (spawningEnabled){
            int spawnerIndex = rnd.Next(0,fishSpawnerArray.Length);

            Vector3 rndPosition = fishSpawnerArray[spawnerIndex].transform.position;
            rndPosition.x += (float)rnd.NextDouble() * 2f * maxDistFromSpawner - maxDistFromSpawner;
            rndPosition.y += (float)rnd.NextDouble() * 2f * maxDistFromSpawner - maxDistFromSpawner;
            rndPosition.z = 0f;
            Instantiate(fishPrefab, rndPosition, transform.rotation);
            spawnTimer = 0f;
        }

    }

}
