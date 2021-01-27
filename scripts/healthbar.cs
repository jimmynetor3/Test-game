// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// public class healthbar : MonoBehaviour
// {
//     GameObject myTextgameObject; // gameObject in Hierarchy
//     Text ourComponent;           // Our refference to text component
//     public int HP = 3;
//     public static healthbar instace;
//     void Start () {
//         instace = this;
//     }
//
//     void Update()
//     {
//          
//         // Find gameObject with name "MyText"
//         myTextgameObject = GameObject.Find("TextHP"); 
//         
//         // Get component Text from that gameObject
//         ourComponent = myTextgameObject.GetComponent<Text>();
//         
//         // Assign new string to "Text" field in that component
//         ourComponent.text = ($" player HP  X{HP}");
//     }
// }
