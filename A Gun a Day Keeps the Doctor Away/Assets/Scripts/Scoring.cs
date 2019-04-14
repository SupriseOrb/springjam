using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scoring : MonoBehaviour
{
    public float score = 0;
    int sceneNum;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Scene currentScene = SceneManager.GetActiveScene();
        sceneNum = currentScene.buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        //65 vs 443
    }

    private void OnGUI()
    {
        //Score display
        if (sceneNum == 1 || sceneNum == 4)
        {
            GUIStyle scoreStyle = new GUIStyle();
            scoreStyle.fontSize = 30;
            scoreStyle.normal.textColor = Color.white;
            GUI.Label(new Rect(10, 10, 100, 50), "Insurance: -$" + score.ToString() + "k", scoreStyle);
        }
    }
}
