using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 16;

    private float spawnPosZ = 20;

    private float startDelay = 1;

    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //at the start of the game, activates the random spawning function
        InvokeRepeating("SpawnRandomANimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomANimal()
    {
        //While the random spawing function is active, this spawns a random animal object within the established range
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }    
}
