using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvin : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(stop());
        } 
    }

   IEnumerator stop()
   {
       print("het werkt");
       
       yield return new WaitForSeconds(2);
       
       print("het werkt nog steeds");
   }
   
}
