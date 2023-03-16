﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = 0;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 9;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
  
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // Generate random ball index and random spawn position
        spawnInterval = Random.Range(2.5f ,4.0f);
        Debug.Log("spawnInterval:" + spawnInterval);

        // instantiate ball at random spawn location

        Invoke("SpawnRandomBall", spawnInterval);
    }

}
