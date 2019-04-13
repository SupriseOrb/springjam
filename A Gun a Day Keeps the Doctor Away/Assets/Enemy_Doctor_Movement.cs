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

    // Start is called before the first frame update
    void Awake()
    {
        waitTime = StaticWaitTime;
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
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
            }
        }

        //if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        //{
         //   transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
           
        //}

    }


}
