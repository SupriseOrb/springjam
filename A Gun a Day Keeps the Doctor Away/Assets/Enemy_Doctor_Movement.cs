using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Doctor_Movement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;
    public float DashState;
    public bool canDocDash = true;
    public Vector2 savedVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DashState > 0)
        {
            canDocDash = false;
            DashState -= Time.deltaTime;
        }

        
        if (DashState <= 0)
        {
            canDocDash = true;
        }

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
           
        }

    }
}
