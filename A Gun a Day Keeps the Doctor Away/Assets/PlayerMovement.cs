using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        TurnRightAndLeft();
    }

    void MoveForward()
    {

        if (Input.GetKey("w"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0, -1 * playerSpeed * Time.deltaTime, 0);
        }
    }

    void TurnRightAndLeft()
    {

        if (Input.GetKey("d")) //Right arrow key to turn right
        {
            transform.Rotate(-Vector3.forward * turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))//Left arrow key to turn left
        {
            transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
        }
    }
}
