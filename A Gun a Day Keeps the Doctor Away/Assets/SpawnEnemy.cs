using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject theplayer;
    ShootandHealth playerScript;
    public int health;

    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Awake()
    {
        playerScript = theplayer.GetComponent<ShootandHealth>();
        health = playerScript.health;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime,spawnTime);
    }

    void Spawn()
    {
        if (health <= 0f)
        {
            return;
        }
        int SpawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[SpawnPointIndex].position, spawnPoints[SpawnPointIndex].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        health = playerScript.health;
    }
}
