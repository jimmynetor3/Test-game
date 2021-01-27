using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoots_Gun : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject bullet;
    public float repeatRate = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoots_gun" ,2.5f ,repeatRate);
    }
    
    public void shoots_gun()
    {
         Instantiate(bullet, SpawnPoint.position , SpawnPoint.rotation);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
