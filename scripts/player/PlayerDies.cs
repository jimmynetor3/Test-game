using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerDies : MonoBehaviour
{
    public Vector3 jump ;
    public bool takeDamage;
    GameObject myTextgameObject; // gameObject in Hierarchy
    Text ourComponent;           // Our refference to text component
    public static int HP = 3;
    public int timeBetweenDamage = 2;
    public Animator animator;
   
    void Update()
    {
        if (HP == 0)
        {
            SceneManager.LoadScene("scenes/main menu", LoadSceneMode.Single);
        }
       
        
        // Find gameObject with name "MyText"
        myTextgameObject = GameObject.Find("TextHP"); 
        
        // Get component Text from that gameObject
        ourComponent = myTextgameObject.GetComponent<Text>();
        
        // Assign new string to "Text" field in that component
        ourComponent.text = ($" player HP  X{HP}");
    }
    // Start is called before the first frame update
    void Start()
    {
        takeDamage = true;
        Physics2D.IgnoreLayerCollision(8,9,false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(stop());
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            StartCoroutine(stop());
        }
    }

    IEnumerator stop()
     {
         if (takeDamage)
         { 
             HP--;
             animator.SetBool("takesDamage" , true);
             takeDamage = false;
             yield return new WaitForSeconds(timeBetweenDamage);
             takeDamage = true;
             animator.SetBool("takesDamage" , false);
         }
         print($"{HP}");
         Physics2D.IgnoreLayerCollision(8,9,true);
         yield return new WaitForSeconds(timeBetweenDamage);
         Physics2D.IgnoreLayerCollision(8,9,false);
         
     }
}
