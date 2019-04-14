using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuButtons : MonoBehaviour
{
    public GameObject instructionP;
    public GameObject creditsP;
    static public bool buttonPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        Scoring.score = 0;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        instructionP.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        creditsP.gameObject.SetActive(true);
    }

    public void Back()
    {
        buttonPressed = true;
        instructionP.gameObject.SetActive(false);
        creditsP.gameObject.SetActive(false);
    }

}
