using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
    0, spawnPosZ);

        int anaimalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[anaimalIndex], spawnPos,
            animalPrefabs[anaimalIndex].transform.rotation);
    }
}
