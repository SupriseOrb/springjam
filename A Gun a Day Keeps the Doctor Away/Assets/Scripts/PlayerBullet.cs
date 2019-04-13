using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float velY = 5f;
    public float velX = 0;
    public int travelled = 0;
    public int range;
    public GameObject theplayer;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //range = theplayer.range;
    }


    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velX,velY);
        //travelled += velY;
        if (travelled >= range)
        {
            //destroy
        }
    }
}
