using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Slime;
    public float timeBetweenWaves = 2f;
    public int increaseDifficulty = 1;
    public float spawnRange = 10f;
    public float speedMovement = 3f;
    public int damage = 2;
    public Transform player;
    private UnityEngine.AI.NavMeshAgent enemyMov;

    private int currentWave = 1;

    private void Start()
    {
        StartCoroutine(GenerateWave());
        enemyMov = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

     private void Update()
    {
        if (player != null)
        {
            enemyMov.SetDestination(player.position);
        }
    }

    private IEnumerator GenerateWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenWaves);

            for (int i = 0; i < currentWave; i++) 
            {
                Vector3 positionSpawn = spawnRange();
                Enemy();
                yield return new WaitForSeconds(5f); 
            }

            currentWave += increaseDifficulty;
        }
    }
}