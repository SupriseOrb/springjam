using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject GameController;
    Scoring scorescript;
    public float speed;
     float travelled = 0;
    public float range;
    // public GameObject theplayer;
    void Start()
    {
        scorescript = GameController.GetComponent<Scoring>();
    }

    private void Awake()
    {
     //   Vector3 newRotation = new Vector3(theplayer.transform.eulerAngles.x, theplayer.transform.eulerAngles.x, theplayer.transform.eulerAngles.z);
       // gameObject.transform.eulerAngles = newRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        travelled += Time.deltaTime;
        if (travelled >= range)
        {
            Destroy(gameObject);
            //destroy
        }


        

     /*   void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "enemy")
            {
                Destroy(col.gameObject);
            }
        }*/
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            scorescript.score += 10;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
