using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] EnemyAI enemyPrefab;
    [SerializeField] Transform[] enemySpawnPositions;
    [SerializeField] float spawnDelay = 5f;

    int enemyPosition;

    private void Start()
    {
        enemyPosition = UnityEngine.Random.Range(0, enemySpawnPositions.Length);
    }

    private void Update()
    {
        StartCoroutine(SpawnZombies());
    }

    IEnumerator SpawnZombies()
    {
        Instantiate(enemyPrefab, enemySpawnPositions[enemyPosition]);
        enemyPosition = UnityEngine.Random.Range(0, enemySpawnPositions.Length);
        yield return new WaitForSeconds(spawnDelay);
    }
}
