using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuButtons : MonoBehaviour
{
    public GameObject instructionP;
    public GameObject creditsP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        //SceneManager.LoadScene(2);
        instructionP.gameObject.SetActive(true);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        //SceneManager.LoadScene(4);
        creditsP.gameObject.SetActive(true);
    }

    public void Back()
    {
        instructionP.gameObject.SetActive(false);
        creditsP.gameObject.SetActive(false);
    }
}
