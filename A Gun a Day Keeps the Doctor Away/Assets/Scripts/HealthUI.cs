using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    private Text hText;
    public GameObject theplayer;
    ShootandHealth playerScript;
    // Start is called before the first frame update
    void Start()
    {
        hText = this.GetComponent<Text>();
        playerScript = theplayer.GetComponent<ShootandHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        hText.text = "Health: " + playerScript.health.ToString();
        if (playerScript.health >= 66)
        {
            hText.color = Color.green;
        }
        else if (playerScript.health >= 33)
        {
            hText.color = Color.yellow;
        }
        else
        {
            hText.color = Color.red;
        }
    }
}
