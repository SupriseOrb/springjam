using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scoring : MonoBehaviour
{
    static public float score = 0;
    static public bool ranOutOfHealth;
    // Start is called before the first frame update
    void Start()
    {
        ranOutOfHealth = false;
    }

    // Update is called once per frame
    void Update()
    {
        //65 vs 443
    }

    void OnGUI()
    {
        //Score display
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 30;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 100, 50), "Insurance: -$" + score.ToString() + "k", scoreStyle);
        
    }
}
