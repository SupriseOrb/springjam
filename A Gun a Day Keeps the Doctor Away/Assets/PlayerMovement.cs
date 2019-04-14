using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float turnSpeed;
    public Rigidbody2D rb2D;
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float movementLimiter = 0.7f;

    public float runSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //MoveForward();
        faceMouse();
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= movementLimiter;
            vertical *= movementLimiter;
        }
        rb2D.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
        transform.up = direction;
    }



    void MoveForward()
    {

        if (Input.GetKey("w"))//Press up arrow key to move forward on the Y AXIS
        {
            //rb2D.AddForce(transform.up * playerSpeed, ForceMode2D.Force);
            rb2D.velocity = transform.up * playerSpeed;
            //transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))//Press up arrow key to move forward on the Y AXIS
        {
            rb2D.velocity = transform.up * playerSpeed * -1;


//            rb2D.AddForce(new Vector2(0, playerSpeed * Time.deltaTime * -1), ForceMode2D.Force);
            //transform.Translate(0, -1 * playerSpeed * Time.deltaTime, 0);
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
