using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootandHealth : MonoBehaviour
{
    public int health = 85;
    public int currentWeap = 0;
    public int range = 10;
    public int tick = 0; //tracks how many frames has passed to know when to decrease health again
    public GameObject bullet;
    public float shotgunrate;
    public float pistolrate;
    public float gatlingrate;
    public float reloadtime;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation);
        if (health >= 100)
        {
            GameOver();
        }
        else if (health >= 66)
        {
            currentWeap = 1;
        }
        else if (health >= 33)
        {
            currentWeap = 1;
        }
        else
        {
            currentWeap = 1;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        }
        tick += 1;
        if (tick >= 60)
        {
            health -= 1;
            tick = 0;
        }
        reloadtime += Time.deltaTime;
        Debug.Log("shootandhealth update");
    }

    void Attack()
    {
        //pistol
        if (currentWeap == 0 && reloadtime >= pistolrate)
        {
           
                Instantiate(bullet, transform.position, transform.rotation);
                reloadtime = 0;
            
//            range = 10;
        }
        //shotgun
        else if (currentWeap == 1 && reloadtime >= shotgunrate)
        {

            GameObject bullet1 = Instantiate(bullet, transform.position, transform.rotation);
            GameObject bullet2 = Instantiate(bullet, transform.position, transform.rotation);
            bullet2.transform.Rotate(Vector3.forward * 10);
            GameObject bullet3 = Instantiate(bullet, transform.position, transform.rotation);
            bullet3.transform.Rotate(Vector3.forward * 5);
            GameObject bullet4 = Instantiate(bullet, transform.position, transform.rotation);
            bullet4.transform.Rotate(Vector3.forward * (-10));
            GameObject bullet5 = Instantiate(bullet, transform.position, transform.rotation);
            bullet5.transform.Rotate(Vector3.forward * (-5));
            transform.Translate(0, -1 * 150 * Time.deltaTime, 0);
            //StartCoroutine("shotgun");

            //if (reloadtime <= shotgunrate)
            //{

            reloadtime = 0;
            //}
            
        }
        //gatling
        else if (currentWeap == 2 && reloadtime >= gatlingrate)
        {
                GameObject bullet6 = Instantiate(bullet, transform.position, transform.rotation);
                GameObject bullet7 = Instantiate(bullet, transform.position, transform.rotation);
            GameObject bullet8 = Instantiate(bullet, transform.position, transform.rotation);
            bullet6.transform.Rotate(Vector3.forward * 3);
                bullet7.transform.Rotate(Vector3.forward * (-3));
            transform.Translate(0, -1 * 10 * Time.deltaTime, 0);
            
            //bullet7.transform.position.x -= 2;
        }
        //Instantiate(bullet, transform.position, transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag == "enemy")
        {
            health += 10;
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
    }


    IEnumerator gat()
    {
        GameObject bullet1 = Instantiate(bullet, transform.position, transform.rotation);
        GameObject bullet2 = Instantiate(bullet, transform.position, transform.rotation);
        bullet2.transform.Rotate(Vector3.forward * 10);
        GameObject bullet3 = Instantiate(bullet, transform.position, transform.rotation);
        bullet3.transform.Rotate(Vector3.forward * 5);
        GameObject bullet4 = Instantiate(bullet, transform.position, transform.rotation);
        bullet4.transform.Rotate(Vector3.forward * (-10));
        GameObject bullet5 = Instantiate(bullet, transform.position, transform.rotation);
        bullet5.transform.Rotate(Vector3.forward * (-5));
        yield return new WaitForSeconds(3);
    }
}
