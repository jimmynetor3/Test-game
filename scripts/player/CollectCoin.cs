using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectCoin : MonoBehaviour
{
    GameObject myTextgameObject; // gameObject in Hierarchy
    Text ourComponent;           // Our refference to text component
    public static int coins = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("coin"))
        {
            coins++;
        }
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("coin"))
    //     {
    //         coins++;
    //     }
    // }
    
    // Update is called once per frame
    void Update()
    {
        // Find gameObject with name "MyText"
        myTextgameObject = GameObject.Find("TextCoins"); 
        
        // Get component Text from that gameObject
        ourComponent = myTextgameObject.GetComponent<Text>();
        
        // Assign new string to "Text" field in that component
        ourComponent.text = ($" Coins  X{coins}");
    }
}
