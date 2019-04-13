using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse_Enemy_Movement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;

    public static int score;
    public string text;


    public int NurseMaxHealth = 50;
    public int NurseCurHealth;
    public int scoreValue = 10;
    bool isDead;
    public AudioClip nurseDeath;

    Animator anim;
    AudioSource NurseAudio;

    void Awake()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        anim = GetComponent<Animator>();
        NurseAudio = GetComponent<AudioSource>();
        NurseCurHealth = NurseMaxHealth;

        score = 0;
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    void NurseDead()
    {
        isDead = true;
        anim.SetTrigger("Dead");
        NurseAudio.clip = nurseDeath;
        NurseAudio.Play();
    }
    public void TakeDamage (int amount, Vector3 hitpoint)
    {
        if (isDead)
        {
            return;
        }
        NurseAudio.Play();
        NurseCurHealth -= amount;
        if(NurseCurHealth <= 0)
        {
            NurseDead();
        }
    }

    public void deSpawn()
    {
        //despwan the nurse
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //chase coding
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        //Still need to add the aditional score portion
    }


}
