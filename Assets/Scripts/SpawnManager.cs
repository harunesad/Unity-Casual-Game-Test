using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float start = 3.0f;
    private float spawnRepeat = 1.5f;
    private PlayerTwoController controller;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", start, spawnRepeat);
        controller = GameObject.Find("Controller").GetComponent<PlayerTwoController>();
    }
    void Update()
    {

    }
    public void SpawnRandomAnimal()
    {
        int animalPosX = Random.Range(-10, 10);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        if (controller.gameOver == false)
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(animalPosX, 0, 12), animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
