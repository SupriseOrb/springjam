using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health;
    public int difference;
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
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 30;
        GUI.Label(new Rect(10, 10, 100, 50), "Health: " + health.ToString(),myStyle);
    }
}
