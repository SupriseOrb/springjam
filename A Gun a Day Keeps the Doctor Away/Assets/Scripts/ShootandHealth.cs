using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShootandHealth : MonoBehaviour
{
    private Rigidbody2D rb2D;
    static int statichealth = 85;
    public int health = 67;
    public int currentWeap = 0;
    public int range = 10;
    public int tick = 0; //tracks how many frames has passed to know when to decrease health again
    private float lasthit;
    public bool hit = false;

    public GameObject bullet;
    public float shotgunrate;
    public float pistolrate;
    public float gatlingrate;
    public float reloadtime;

    public AudioSource shotgunload;
    public AudioSource shotgunshoot;
    public AudioSource pistolload;
    public AudioSource pistolshoot;
    public AudioSource gatlingload;
    public AudioSource gatlingshoot;

    public Sprite lowhp;
    public Sprite medhp;
    public Sprite hihp;
    SpriteRenderer sr;
    float nextSoundTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        //health = 85;
        sr = GetComponent<SpriteRenderer>();
        lasthit = Time.time;
        rb2D = gameObject.AddComponent<Rigidbody2D>();
    }
    void Awake()
    {
        //health = statichealth;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
        if (health >= 100 || health <= 0)
        {
            if (health >= 100)
            {
                Scoring.ranOutOfHealth = true;
            }
            else
            {
                Scoring.ranOutOfHealth = false;
            }
            GameOver();
        }
        else if (health < 100 && health >= 66)
        {
            if (health == 100)
            {
                
                if (!pistolload.isPlaying)
                {
                    pistolload.Play();
                }
            }
            if (health == 66)
            {
                if (!pistolload.isPlaying)
                {
                    pistolload.Play();
                }
            }

            currentWeap = 0;
            sr.sprite = hihp;
        }
        else if (health <= 65 && health >= 33)
        {
            if (health == 65)
            {
                if (!shotgunload.isPlaying)
                {
                    shotgunload.Play();
                }
            }
            if (health == 33)
            {
                if (shotgunload.isPlaying)
                {
                    shotgunload.Play();
                }
            }
            currentWeap = 1;
            sr.sprite = medhp;
        }
        else if (health <= 32)
        {
            if (health == 32)
            {
                if (!gatlingload.isPlaying)
                {
                    gatlingload.Play();
                }
            }
            
            currentWeap = 2;
            sr.sprite = lowhp;
     
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Attack();
        }

        if (hit == true)
        {
            lasthit = Time.time;
            hit = false;
        }

        tick += 1;
        if (tick >= 60)
        {
            if (Time.time - lasthit < 5)
            {
                health -= 1;
            }
            else if (Time.time - lasthit < 10)
            {
                health -= 2;
            }
            else
            {
                health -= 3;
            }
            tick = 0;
        }
        reloadtime += Time.deltaTime;
        //Debug.Log("shootandhealth update");
    }

    void Attack()
    {
        //pistol
        if (currentWeap == 0 && reloadtime >= pistolrate)
        {
            pistolshoot.Play();
            Instantiate(bullet, transform.position, transform.rotation);
                reloadtime = 0;
            
//            range = 10;
        }
        //shotgun
        else if (currentWeap == 1 && reloadtime >= shotgunrate)
        {
            shotgunshoot.Play();
            GameObject bullet1 = Instantiate(bullet, transform.position, transform.rotation);
            GameObject bullet2 = Instantiate(bullet, transform.position, transform.rotation);
            bullet2.transform.Rotate(Vector3.forward * 10);
            GameObject bullet3 = Instantiate(bullet, transform.position, transform.rotation);
            bullet3.transform.Rotate(Vector3.forward * 5);
            GameObject bullet4 = Instantiate(bullet, transform.position, transform.rotation);
            bullet4.transform.Rotate(Vector3.forward * (-10));
            GameObject bullet5 = Instantiate(bullet, transform.position, transform.rotation);
            bullet5.transform.Rotate(Vector3.forward * (-5));
            //transform.Translate(0, -1 * 150 * Time.deltaTime, 0);
            //StartCoroutine("shotgun");
            StartCoroutine(Knockback());
            //Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 150, transform.position.z), 150);
            //if (reloadtime <= shotgunrate)
            //{

            reloadtime = 0;
            //}
            
        }
        //gatling
        else if (currentWeap == 2 && reloadtime >= gatlingrate)
        {
             // can't play sounds if before this time
                                     // can't play if last one not finished:
            if (Time.time >= nextSoundTime)
            {
                gatlingshoot.Play();
                nextSoundTime = Time.time + 0.1f;
            }
            GameObject bullet6 = Instantiate(bullet, transform.position, transform.rotation);
            GameObject bullet7 = Instantiate(bullet, transform.position, transform.rotation);
            GameObject bullet8 = Instantiate(bullet, transform.position, transform.rotation);
            bullet6.transform.Rotate(Vector3.forward * 3);
                bullet7.transform.Rotate(Vector3.forward * (-3));
            transform.Translate(0, -1 * 10*Time.deltaTime, 0);
            

            //bullet7.transform.position.x -= 2;
        }
        //Instantiate(bullet, transform.position, transform.rotation);
    }


    void GameOver()
    {
        Debug.Log("gameover");
        SceneManager.LoadScene(3);
    }

    public IEnumerator Knockback()
    {

        float timer = 0;

        for (int i = 50; i > 0; i--)
        {
            transform.Translate(0, -0.005f , 0);
            //yield return new WaitForSeconds(0.000000005f);
        }

        yield return 0;

    }

}
