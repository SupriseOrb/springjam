using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Doctor_Movement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;
    public float StaticDashTime;
    private float DashTime;
    public bool canDocDash = true;
    public float StaticWaitTime;
    float waitTime;
    Vector3 TargetPosition;

    public Vector2 savedVelocity;

    //Attack Variables
    public float attackRange;
    public int damage;
    private float lastAttackTime;
    public float attackDelay;

    //Player Health Variables
    public GameObject theplayer;
    ShootandHealth healthScript;

    //Score Variables
    public GameObject gamecontroller;
    Scoring scoreScript;

    // Start is called before the first frame update
    void Awake()
    {
        theplayer = GameObject.Find("Player");
        waitTime = StaticWaitTime;
        target = theplayer.GetComponent<Transform>();
        //speed = 1;
        //attackDelay = 2;
        //attackRange = 3;
        healthScript = theplayer.GetComponent<ShootandHealth>();
        scoreScript = gamecontroller.GetComponent<Scoring>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //chase coding
        //if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        //{
            //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //    transform.Translate(0, speed * Time.deltaTime, 0);
        //}

        if (DashTime == StaticDashTime)
        {
            TargetPosition = target.position;
        }

        if (DashTime > 0)
        {

            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);

            }
            

            //canDocDash = false;
            DashTime -= Time.deltaTime;
        }


        if (DashTime <= 0)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
            DashTime = StaticDashTime;
            waitTime = StaticWaitTime;
                Vector3 dir = theplayer.transform.position - transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            }
        }

        //if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        //{
        //   transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //}

        //Attack? Checking Distance between Player and Nurse
        float distanceToPlayer = Vector3.Distance(transform.position, target.position);
        if (distanceToPlayer < attackRange)
        {
            //check if enough time has passed since last attack
            if (Time.time > lastAttackTime + attackDelay)
            {
                healthScript.hit = true;
                healthScript.health += damage;
                //Record Time Attacked
                lastAttackTime = Time.time;
            }
        }

    }


}
