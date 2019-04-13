using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse_Enemy_Movement : MonoBehaviour
{
    //Nurse Movement Varibles
    public float speed;
    public float stoppingDistance;
    private Transform target;

    //Score Variables
    public static int score;
    public string text;

    //Nurse Health Values + Score
    public int NurseMaxHealth = 50;
    public int NurseCurHealth;
    public int scoreValue = 10;

    //Nurse Death + Animiation?
    bool isDead;
    public AudioClip nurseDeath;
    Animator anim;
    AudioSource NurseAudio;

    //Attack Variables
    public float attackRange;
    public int damage;
    private float lastAttackTime;
    public float attackDelay;


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

        //Attack? Checking Distance between Player and Nurse
        float distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer < attackRange)
        {
            //check if enough time has passed since last attack
            if (Time.time > lastAttackTime + attackDelay)
            {
                target.SendMessage("TakeDamage");
                //Record Time Attacked
                lastAttackTime = Time.deltaTime;
            }
        }

    }


}
