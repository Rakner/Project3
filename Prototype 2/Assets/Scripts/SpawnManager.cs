using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float rotationY = 90;
    private float spwanRangeXSide = 24.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalSideLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalSideRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalTop(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalSideLeft(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spwanRangeXSide ,0, Random.Range(0, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,rotationY,0));
    }

    void SpawnRandomAnimalSideRight(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spwanRangeXSide ,0, Random.Range(0, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0,-rotationY,0));
    }
}
