using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scoring : MonoBehaviour
{
    static public float score = 0;
    static public bool ranOutOfHealth;
    private int tick;
    // Start is called before the first frame update
    void Start()
    {
        ranOutOfHealth = false;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += 1;
        if (tick >= 120)
        {
            score += 1;
            tick = 0;
        }
    }

}
