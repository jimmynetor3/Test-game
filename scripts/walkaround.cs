using System;
using UnityEngine;
using System.Collections;

public class walkaround : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    Rigidbody2D enemyRigidBody2D;
    public int EnemySpeed = 50000;
    public bool GoRight;
    public bool _moveRight;
    public float RepeatRate = 6f;

    // Use this for initialization
   
    public void Start()
    {
        // InvokeRepeating("ChangeBool",1f,RepeatRate);
        GoRight = false;
        _moveRight = true;
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("Player"))
        {
            if (GoRight)
            {
                GoRight = false;
                _moveRight = true;
            }
            else
            {
                GoRight = true;
                _moveRight = false;
            }
        }
    }
    
    public void Update()
    {

        if (_moveRight)
        {
            enemyRigidBody2D.AddForce(Vector2.right * (EnemySpeed * Time.deltaTime));
            FlipRight();
        }
        
        
        if (!_moveRight)
        {
            enemyRigidBody2D.AddForce(Vector2.left * (EnemySpeed * Time.deltaTime));
            FlipLeft();
        }
        
    }
    
    public void FlipLeft()
    {
        spriteRenderer.flipX = false;
    }
    
    public void FlipRight()
    {
        spriteRenderer.flipX = true;
    }



     
}