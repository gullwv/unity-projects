using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spawn an animal when S is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {

            SpawnRandomAnimal();

        }

    }

    void SpawnRandomAnimal()
    {

        int animalIndex = Random.Range(0, animalPrefabs.Length); // random animal
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // spawn animal.

    }

}
