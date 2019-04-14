﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Movement_NoRotation : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float movementLimiter = 0.7f;

    public float runSpeed = 20.0f;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= movementLimiter;
            vertical *= movementLimiter;
        }
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
