using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : MonoBehaviour
{
    public int MaxHealth = 125;
    public int curHealth = 100;
    public float healthBarLength;

    public bool isPoisoned = false;
    bool poisonEffect = true;
    public int poisonDamage = 5;

    public float poisonTimer;

    private void Awake()
    {
        healthBarLength = Screen.width / 3;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator PoisonDamage ()
    {
        if (poisonEffect)
        {
            curHealth -= poisonDamage;
            poisonEffect = false;
            yield return new WaitForSeconds(poisonTimer);
            poisonEffect = true;
        }
    }
    // Update is called once per frame
    void Update()
    { 
        if (isPoisoned== true);
        {
            StartCoroutine("PoisonDamage");
        }
    }
   
}
