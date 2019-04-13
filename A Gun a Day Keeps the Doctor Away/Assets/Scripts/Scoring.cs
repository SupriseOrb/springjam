using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //65 vs 443
    }

    private void OnGUI()
    {
        //Score display
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 30;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 100, 50), "Insurance: -$" + score.ToString() + "k", scoreStyle);
    }
}
