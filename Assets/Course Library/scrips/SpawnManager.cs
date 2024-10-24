using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;

    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPositon(), enemyPrefab.transform.rotation);

    }
    private Vector3 GenerateSpawnPositon()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
         return randomPos;
    }

    void Update()
    {
        
    }
}
