using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    //I used this script, to give the coins a visual touch
    public GameObject coin;
    public float SpawnRange = 10f; //this will make me create coins in random places
    private float speed = 180; //I have put the rotation speed of the coins here

    private void Start()
    {
        GenerateCoin();
    }

    private void GenerateCoin()
    {
        for (int i = 0; i < 1; i++)
        {
            Vector3 spawnPosition = getRandomPosition();
            createCoin(spawnPosition);
        }
    }

     private Vector3 getRandomPosition()
    {
        Vector3 randomPosition = transform.position + Random.insideUnitSphere * SpawnRange;
        return randomPosition;
    }

       private void createCoin(Vector3 spawnPosition)
    {
        Instantiate(coin, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        //here we tell him to rotate on himself with x
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
