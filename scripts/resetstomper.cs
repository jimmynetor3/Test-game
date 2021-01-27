using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetstomper : MonoBehaviour
{
   
    private float speed = 0.1f;
    public float gravity = 9f;
    public bool resetpos = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
   
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            reset();
        }
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Player"))
        {
            attack();
        }
    }

    private void OnTriggerExit2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Player"))
        {
            sleep();
        }
    }

    public void sleep()
    {
        resetpos = true;
    }
    public void reset()
    {
        this.GetComponent<Rigidbody2D>().gravityScale = gravity ;
        transform.Translate(0f, 100f, speed*Time.deltaTime*1);
        if (resetpos)
        {
            gravity = 0;
            this.GetComponent<Rigidbody2D>().gravityScale = gravity ;
        }
    }

    public void attack()
    {
        resetpos = false;
        gravity = 9;
        print("stomper boos");
        this.GetComponent<Rigidbody2D>().gravityScale = gravity ;
    }
}