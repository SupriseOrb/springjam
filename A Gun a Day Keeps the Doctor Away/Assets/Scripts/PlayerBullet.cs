using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
     float travelled = 0;
    public float range;
   // public GameObject theplayer;

    void Start()
    {
  
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
    }
}
