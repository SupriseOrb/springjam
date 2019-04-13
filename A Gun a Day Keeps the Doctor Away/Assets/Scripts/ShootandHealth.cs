using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootandHealth : MonoBehaviour
{
    public int health = 85;
    public int currentWeap = 0;
    public int range = 10;
    public int tick = 0; //tracks how many frames has passed to know when to decrease health again
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 100)
        {
            GameOver();
        }
        else if (health >= 66)
        {
            currentWeap = 0;
        }
        else if (health >= 33)
        {
            currentWeap = 1;
        }
        else
        {
            currentWeap = 2;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        }
        tick += 1;
        if (tick >= 60)
        {
            health -= 1;
            tick = 0;
        }
        Debug.Log("shootandhealth update");
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
        Instantiate(bullet, transform.position, transform.rotation);
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
