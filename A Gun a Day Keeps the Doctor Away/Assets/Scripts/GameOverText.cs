using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverText : MonoBehaviour
{
    public GameObject loseP;
    public GameObject winP;
    private Text overtext;
    // Start is called before the first frame update
    void Start()
    {
        overtext = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Scoring.ranOutOfHealth == false)
        {
            winP.gameObject.SetActive(true);
            overtext.text = "Daddy Riley lives! Here's how much you helped him make: \n\n$" + Scoring.score.ToString() + "k\n\n";
            if (Scoring.score < 300)
            {
                overtext.text += "You made some money but you could have definitely made more.";
            }
            else if (Scoring.score < 900)
            {
                overtext.text += "That's a lot of money! You think you could make more?";
            }
            else if (Scoring.score < 2000)
            {
                overtext.text += "Your insurance company is definitely regretting this! Do you think you can go higher?";
            }
            else
            {
                overtext.text += "You definitely cheated";
            }
        }
        if (Scoring.ranOutOfHealth == true)
        {
            loseP.gameObject.SetActive(true);
            overtext.text = "You didn't keep Daddy Riley alive! You can't cash out your: \n\n$" + Scoring.score.ToString() + "k\n\n";
            if (Scoring.score < 300)
            {
                overtext.text += "Don't worry, it wasn't a lot of money anyways.";
            }
            else if (Scoring.score < 900)
            {
                overtext.text += "It was a lot but you could always make it back with another try!";
            }
            else
            {
                overtext.text += "Your insurance company dodged a bullet there. You need to live to cash out!";
            }
        }
    }
}
