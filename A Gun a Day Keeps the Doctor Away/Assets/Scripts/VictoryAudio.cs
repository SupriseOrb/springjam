using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource theaudio;
    void Start()
    {
        theaudio = this.GetComponent<AudioSource>();
        if (Scoring.ranOutOfHealth == true)
        {
            theaudio.gameObject.SetActive(false);
        }
    }
    
}
