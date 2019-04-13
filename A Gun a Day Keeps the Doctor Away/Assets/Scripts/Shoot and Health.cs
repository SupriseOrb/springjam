using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootandHealth : MonoBehaviour
{
    public int health = 100;
    public int currentWeap = 0;
    public int range = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 125)
        {
            GameOver();
        }
        else if (health >= 67)
        {
            currentWeap = 0;
        }
        else if (health >= 34)
        {
            currentWeap = 1;
        }
        else
        {
            currentWeap = 2;
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Attack();
        }
        health -= 1;
    }

    void Attack()
    {
        if (currentWeap == 0)
        {
            range = 10;
        }
        else if (currentWeap == 1)
        {
            range = 30;
        }
        else
        {
            range = 50;
        }
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag == "enemy")
        {
            health += 10;
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
    }
}
