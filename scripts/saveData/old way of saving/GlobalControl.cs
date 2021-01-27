using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// Game Master class, needs to be in every level.
/// </summary>
public class GlobalControl : MonoBehaviour 
{
	public static GlobalControl Instance;

    //TUTORIAL
    public PlayerStatistics savedPlayerData;

	//Copy or our player, if we ever need it game-wide
	public GameObject Player;

	//Transition target is set by TransitionScript component, when interacted with. 
	//This enables us to spawn the player at custom location when next scene is loaded.
	//To use this, first go to your destination scene, and make an empty GameObject and position it
	//where you would like for player to spawn, and use Copy on transform component. 
	//Next, go to your source scene, make empty GameObject, and paste component values. This will position the 
	//game object at some arbitrary position. Assign this game object as transition target to the TransitionScript.
	//Your player will be moved to that location after next scene is loaded.
	public Transform TransitionTarget;
	


	//Pseudo-singleton concept from Unity dev tutorial video:
    void Start()
    {
        Application.targetFrameRate = 144;
    }

    public PlayerStatistics LocalCopyOfData;
    public bool IsSceneBeingLoaded = false;


    public void SaveData()
    {
        if (!Directory.Exists(@"F:\unity\test game\Assets\scripts\saveData\Serializables.cs"))
            Directory.CreateDirectory(@"F:\unity\test game\Assets\scripts\saveData\Serializables.cs");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create(@"F:\unity\test game\Assets\scripts\saveData\Serializables.cs");

        
// LocalCopyOfData = PlayerState.Instance.localPlayerData;
        formatter.Serialize(saveFile, LocalCopyOfData);

        saveFile.Close();
    }

    public void LoadData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Open(@"F:\unity\test game\Assets\scripts\saveData\Serializables.cs", FileMode.Open);

        LocalCopyOfData = (PlayerStatistics)formatter.Deserialize(saveFile);
        
        saveFile.Close();
    }
}