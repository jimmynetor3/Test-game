using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavingSystem
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/PlayerData.data";
        FileStream stream = new FileStream(path, FileMode.Create);
        
        playerdata data = new playerdata();
        if (File.Exists(path))
        {
            Debug.Log($"exported to {path}");
        }
        else
        {
            Debug.Log("iets ging mis");
        }
        
        formatter.Serialize(stream,data);
        stream.Close();
        
    }

    public static playerdata loadPlayer()
    {
        string path = Application.persistentDataPath + "/PlayerData.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Debug.Log($"successfully loaded from {path}");
            
            playerdata data = formatter.Deserialize(stream) as playerdata;
            stream.Close();
            
            Debug.Log($"this is data {data.Coins}");
            
            return data;
        }
        Debug.LogError($"save file not found at {path}");
        return null;

    }
}
