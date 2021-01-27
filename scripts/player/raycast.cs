using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public float x = 1;
    public float y = 1;
    Rigidbody2D rb2D;

    void FixedUpdate()
    {
        //Length of the ray
        float laserLength = 500f;
      
        Vector2 startPosition = (Vector2) transform.position - new Vector2(1, 0);
        //Get the first object hit by the ray
        RaycastHit2D hit = Physics2D.Raycast(startPosition , Vector2.right, laserLength);
 
        //If the collider of the object hit is not NUll
        if (hit.collider != null)
        {
            //Hit something, print the tag of the object
            Debug.Log("Hitting: " + hit.collider.tag);
            //Get the sprite renderer component of the object
            SpriteRenderer sprite = hit.collider.gameObject.GetComponent<SpriteRenderer>();
            //Change the sprite color
            sprite.color = Color.green;
        }
 
        //Method to draw the ray in scene for debug purpose
        Debug.DrawRay(startPosition, Vector2.right * laserLength, Color.red);
    }

}
