using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float velY = 5f;
    public int travelled = 0;
    public int range;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        range = 30;
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,velY);
        //travelled += velY;
        if (travelled == 0)
        {
            //
        }
    }
}
