using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat_Code_Script : MonoBehaviour
{
    private string[] cheatCode;
    private int index;

    private void Awake()
    {
        //Cheat Code is catzrkewl
        cheatCode = new string[] { "c", "a", "t", "z", "r", "k", "e", "w", "l" };
        index = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(cheatCode[index]))
            {
                //+1 to index to check the next key in the code 
                index++;
            }
            else
            {
                index = 0;
            }
        }
        if (index == cheatCode.Length)
        {
            //cheatcode successfully implemented
            //Stick cat stuff here

        }
    }
}
