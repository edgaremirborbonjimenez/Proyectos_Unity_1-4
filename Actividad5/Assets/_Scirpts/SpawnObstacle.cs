using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject[] obstacles;

    public float delay=1.0f;

    public float repeatTime = 2.0f;

    private Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        InvokeRepeating("spawnObstacle",delay,repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnObstacle()
    {
        GameObject obstaculo = obstacles[Random.Range(0, obstacles.Length)];
        Instantiate(obstaculo, spawnPos, obstaculo.transform.rotation);
    }
}
