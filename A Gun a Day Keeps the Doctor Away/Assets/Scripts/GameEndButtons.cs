using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndButtons : MonoBehaviour
{
    public GameObject winP;
    public GameObject loseP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MainMenu()
    {
        winP.gameObject.SetActive(false);
        loseP.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }


}
