﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    public bool isPoisoned = false;
    bool poisonEffect = true;
    public int poisonDamage = 5;

    public float poisonTimer;

    public GameObject theplayer;
    ShootandHealth playerScript;

    private void Awake()
    {
        //healthBarLength = Screen.width / 3;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerScript = theplayer.GetComponent<ShootandHealth>();
    }
    IEnumerator PoisonDamage ()
    {
        if (poisonEffect)
        {
            playerScript.health -= poisonDamage;
            poisonEffect = false;
            yield return new WaitForSeconds(poisonTimer);
            poisonEffect = true;
        }
    }
    // Update is called once per frame
    void Update()
    { 
        if (isPoisoned== true)
        {
            StartCoroutine("PoisonDamage");
        }
    }
   
}
