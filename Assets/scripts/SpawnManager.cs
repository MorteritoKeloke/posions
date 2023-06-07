using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRange = 150f;//limite de la plataforma

    public int enemiesInScene;
    public int enemiesPerWave = 1;
   

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(enemiesPerWave);
        
    }

    // Update is called once per frame
    void Update()
    {
        enemiesInScene = FindObjectsOfType<Enemy>().Length;
        if (enemiesInScene <= 0)
        {
            enemiesPerWave++;
            SpawnEnemyWave(enemiesPerWave);
           
        }
    }
    private Vector3 RandomSpawnPosition()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, RandomSpawnPosition(), Quaternion.identity);
        }
    }
}
