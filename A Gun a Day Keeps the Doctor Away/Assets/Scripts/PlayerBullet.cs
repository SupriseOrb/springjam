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
    //Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
        //range = theplayer.range;
    }

    private void Awake()
    {
        //transform.rotation.z = theplayer.transform.rotation.z;
        Vector3 newRotation = new Vector3(theplayer.transform.eulerAngles.x, theplayer.transform.eulerAngles.x, theplayer.transform.eulerAngles.z);
        gameObject.transform.eulerAngles = newRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 5 * Time.deltaTime, 0);

        //rb.velocity = new Vector2(velX,velY);
        //travelled += velY;
        if (travelled >= range)
        {
            //destroy
        }
    }
}
