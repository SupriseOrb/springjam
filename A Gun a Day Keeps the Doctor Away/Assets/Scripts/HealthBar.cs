using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void OnGUI()
    {
        //Health Count
        GUIStyle healthStyle = new GUIStyle();
        healthStyle.fontSize = 30;
        if (health >= 66)
        {
            healthStyle.normal.textColor = Color.green;
        }
        else if (health >= 33)
        {
            healthStyle.normal.textColor = Color.yellow;
        }
        else
        {
            healthStyle.normal.textColor = Color.red;
        }
        GUI.Label(new Rect(10, 50, 100, 50), "Health: " + health.ToString(),healthStyle);
    }
}
