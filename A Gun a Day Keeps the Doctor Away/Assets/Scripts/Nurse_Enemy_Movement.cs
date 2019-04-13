using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nurse_Enemy_Movement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;

    void Awake()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }


}
