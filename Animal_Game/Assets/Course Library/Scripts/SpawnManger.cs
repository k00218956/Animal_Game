﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                0, spawnPosZ);

            int anaimalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[anaimalIndex], spawnPos,
                animalPrefabs[anaimalIndex].transform.rotation);
        }
    }
}
