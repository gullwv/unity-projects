using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
//         uncomment to spawn an animal when S is pressed. for testing purposes ONLY!
//         if you use this for entertainment purposes, you deserve to sit in the Sad Corner Of Shame.
//         if (Input.GetKeyDown(KeyCode.S))
//         {
//
//            SpawnRandomAnimal();
//
//         }
//
    }

    void SpawnRandomAnimal()
    {

        int animalIndex = Random.Range(0, animalPrefabs.Length); // random animal
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20); // random position

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // spawn animal.\
        Debug.Log("DEBUG - Animal spawned successfully.");

    }

}
