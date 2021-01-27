using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class playermovement : MonoBehaviour
{
    public bool isOnTheGround;
    public bool isWalking;
    public bool isFalling;
    public bool isJumping;
    private float speed = 0.1f;
    public GameObject Player;
    public GameObject Ball;
    public Vector3 jump ;
    public float jumpForce = 28f;
    public float minusLeft = -1.6f;
    public float plusRight = 1.7f;
    public bool isGrounded;
    public float inAirLeft = -1.2f;
    public float inAirright = 1.3f;
    Rigidbody2D rb;
    public Animator animator;
    public bool goingForward;
    public bool goingBackwards;
    public SpriteRenderer spriteRenderer;


    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 30f, 0.0f);
        animator.SetBool("isRunningLeft" , false);
        animator.SetBool("isRunningRight" , false);
        animator.SetBool("isJumpingWhileRunningRight" , false);
        animator.SetBool("isJumpingWhileRunningLeft" , false);
        spriteRenderer.flipX = false;
        
        // changeCharToKeyCode();
        
    }

    // private void changeCharToKeyCode()
    // {
    //     leftButton = (SaveKeyBinds.getKeyForLeft)System.Enum.Parse(typeof(KeyCode));
    // }
    //
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
        }
        else
        {
            isOnTheGround = false;
        }
    }

    void OnCollisionExit2D(){
        animator.SetBool("isGrounded" , false);
        isGrounded = false;
    }
    void OnCollisionStay2D()
    {
        animator.SetBool("isGrounded" , true);
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0.1f, 0f, speed*Time.deltaTime);
        // get positions
 
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("scenes/main menu", LoadSceneMode.Single);
        }

        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            if (isGrounded==false)
            {
                transform.Translate(inAirLeft, 0f, speed * Time.deltaTime);
            }
            else
            {
                goingBackwards = true;
                animator.SetBool("isRunningLeft" , true);
                transform.Translate(minusLeft, 0f, speed * Time.deltaTime);
            }
        } 
        else
        {
            goingBackwards = false;
            animator.SetBool("isRunningLeft" , false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
            if (isGrounded==false)
            {
                transform.Translate(inAirright, 0f, speed * Time.deltaTime);
            }
            else
            { 
                goingForward = true;
                animator.SetBool("isRunningRight" , true);
                transform.Translate(plusRight, 0f, speed * Time.deltaTime);
            }
            // transform.Translate (Vector3(0, 0, 1). right *   movementspeed * Time.deltaTime);
            
        }
        else
        {
            goingForward = false;
            animator.SetBool("isRunningRight" , false);
        }
        // if (Input.GetKey(KeyCode.W)) {
        //     transform.Translate(0f, 2f, speed*Time.deltaTime*2);
        // }
        if(Input.GetKeyDown(KeyCode.W) && isGrounded && !isJumping && isOnTheGround && !isFalling){
     
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        
        // save game
        if (Input.GetKey(KeyCode.F5))
        {
          SavingSystem.SavePlayer();
        }
        
        //loadgame
        if (Input.GetKey(KeyCode.F9))
        {
           print(SavingSystem.loadPlayer());
        }
        
        if (isGrounded == false && goingBackwards)
        {
            animator.SetBool("isJumpingWhileRunningLeft", true);
        }
        else
        {
            animator.SetBool("isJumpingWhileRunningLeft" , false);
        }

        if (isGrounded == false && goingForward)
        {
            animator.SetBool("isJumpingWhileRunningRight" , true);
        }
        else
        {
            animator.SetBool("isJumpingWhileRunningRight" , false);
        }
        
        // check if player is falling
        if (GetComponent<Rigidbody2D>().velocity.y < -0.1 && isGrounded == false)
        {
            animator.SetBool("isFalling" , true);
            isFalling = true;
        }
        else
        {
            animator.SetBool("isFalling" , false);
            isFalling = false;
        }
        // check if player is jumping
        if (GetComponent<Rigidbody2D>().velocity.y > 0.1 && isGrounded == false)
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }
    }
}

