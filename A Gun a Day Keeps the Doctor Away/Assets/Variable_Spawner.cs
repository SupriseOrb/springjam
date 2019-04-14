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
        Vector3 enemyPos = new Vector3(Random.Range(-2.8f, 2.8f), transform.position.y, transform.position.z);
        enemyNo = Random.Range (0,27);
        Instantiate(enemies[enemyNo], enemyPos, transform.rotation);

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
