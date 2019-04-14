using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    static public int health;
    static int statichealth = 85;
    public GameObject theplayer;
    ShootandHealth playerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = theplayer.GetComponent<ShootandHealth>();
        health = 85;
    }
    void Awake()
    {
        health = 85;

    }

    // Update is called once per frame
    void Update()
    {
        //playerScript = theplayer.GetComponent<ShootandHealth>();
        health = playerScript.health;
    }
    
        
    
}
