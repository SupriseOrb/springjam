using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health;
    public int difference;
    public GameObject theplayer;
    //public GameObject theBar;
    //private SpriteRenderer spriterend;
    ShootandHealth playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = theplayer.GetComponent<ShootandHealth>();
        health = playerScript.health;
        //spriterend = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    // Update is called once per frame
    void Update()
    {
        //difference = health - playerScript.health;
        //if (difference > 0)
        //{
        //health has decreased
        //theBar.transform.localScale = playerScript.health / 100;
        //spriterend.transform.localScale = new Vector2(difference, 0);
        //health = playerScript.health;
        //}
        health = playerScript.health;
    }
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 30;
        GUI.Label(new Rect(10, 10, 100, 50), "Health: " + health.ToString(),myStyle);
    }
}
