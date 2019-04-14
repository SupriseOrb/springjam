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
        scoreobj = GameObject.Find("Score");
        scoreScript = scoreobj.GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        overtext.text = "Daddy Riley lives! Here's how much you helped him make: \n" + scoreScript.score.ToString();
    }
}
