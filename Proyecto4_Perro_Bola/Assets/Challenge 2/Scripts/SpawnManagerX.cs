using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private int indexBall;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
       // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    
    float nextSpawn=2.0f;
    float counter = 0.0f;
    void Update(){
        
        //Hacer un spawn a cierto intervalo aleatorio
        counter += Time.deltaTime;
        if(counter>=nextSpawn){
            SpawnRandomBall();
            nextSpawn = Random.Range(2, 5);
            counter = 0;
        }
    
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        indexBall = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[indexBall].transform.rotation);
    }

}
