using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsuranceUI : MonoBehaviour
{
    private Text iText;
    // Start is called before the first frame update
    void Start()
    {
        iText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        iText.text = "Insurance: -$" + Scoring.score.ToString() + "k";
    }
}
