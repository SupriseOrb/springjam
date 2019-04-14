using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverText : MonoBehaviour
{
    private Text overtext;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Scoring.ranOutOfHealth);
        overtext = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(overtext);
        if (Scoring.ranOutOfHealth == true)
        {
            overtext.text = "Daddy Riley lives! Here's how much you helped him make: \n$" + Scoring.score.ToString() + "k";
        }
        if (Scoring.ranOutOfHealth == false)
        {
            overtext.text = "You didn't keep Daddy Riley alive! You can't cash out your: \n$" + Scoring.score.ToString() + "k";
        }
    }
}
