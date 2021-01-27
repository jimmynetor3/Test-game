using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Movement : MonoBehaviour
{
    
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D enemyRigidBody2D;
    public int EnemySpeed = 50;
    public bool MoveRight;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody2D.velocity = Vector2.right * EnemySpeed;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
