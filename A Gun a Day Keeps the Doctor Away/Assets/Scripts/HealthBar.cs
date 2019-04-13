using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health;
    public int difference;
    public GameObject theplayer;
    // Start is called before the first frame update
    void Start()
    {
    //    health = theplayer.health;
    }

    // Update is called once per frame
    void Update()
    {
    //    difference = health - theplayer.health;
        if (difference > 0)
        {
            //health has decreased
    //        HealthBar.transform.localScale = theplayer.health / 100;
    //        health = theplayer.health;
        }
    }
}
