﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        faceMouse();
    }
}
