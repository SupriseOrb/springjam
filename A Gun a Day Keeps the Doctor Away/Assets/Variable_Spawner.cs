using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    int enemyNo;
    public float maxPos = 2.5f;
    public float spawnInterval = 3f;
    public float currentSpawnTime = 0;

    public float midCountdown = 15;
    public float currentCountdownTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void spawn()
    {
        for (int i = 0; i < 10; i++)
        { 
            Vector3 enemyPos = new Vector3(Random.Range(-22.0f, 22.0f), Random.Range(17.0f, -16.0f), transform.position.z);
            enemyNo = Random.Range(0, 1);
            Instantiate(enemies[enemyNo], enemyPos, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        currentSpawnTime += Time.deltaTime;
        currentCountdownTime += Time.deltaTime;
        
        if (currentSpawnTime >= spawnInterval)
        {
            spawn();
            currentSpawnTime = 0;
        }

        if (currentCountdownTime >= midCountdown)
        {
            spawnInterval -= 0.1f;
            currentCountdownTime = 0;
        }

    }

}
