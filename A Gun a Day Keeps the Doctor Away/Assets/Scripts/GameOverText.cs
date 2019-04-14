using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverText : MonoBehaviour
{
    private Text overtext;
    public GameObject scoreobj;
    Scoring scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        overtext = gameObject.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreobj = GameObject.Find("Score");
        scoreScript = scoreobj.GetComponent<Scoring>();
        Debug.Log(scoreScript);
        if (scoreScript.ranOutOfHealth == true)
        {
            overtext.text = "Daddy Riley lives! Here's how much you helped him make: \n" + scoreScript.score.ToString();
        }
        if (scoreScript.ranOutOfHealth == false)
        {
            overtext.text = "You didn't keep Daddy Riley alive! You can't cash out your: \n" + scoreScript.score.ToString();
        }
    }
}
