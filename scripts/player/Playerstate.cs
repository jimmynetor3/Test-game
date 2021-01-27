using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerState : MonoBehaviour 
{
    public static PlayerState instance;

    public Transform playerPosition;

    //TUTORIAL
    public PlayerStatistics localPlayerData = new PlayerStatistics();

    void Awake()
    {
        if (instance == null)
            instance = this;

        if (instance != this)
            Destroy(gameObject);

        GlobalControl.Instance.Player = gameObject;
    }

    //At start, load data from GlobalControl.
    void Start () 
    {
        localPlayerData = GlobalControl.Instance.savedPlayerData;
    }

    void Update()
    {

    }

}