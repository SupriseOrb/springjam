using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health;

    public GameObject theplayer;
    ShootandHealth playerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = theplayer.GetComponent<ShootandHealth>();
        health = playerScript.health;
    }

    // Update is called once per frame
    void Update()
    {
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
