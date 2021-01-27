using System;
using UnityEngine.SceneManagement;

[Serializable]
public class PlayerStatistics
{
    public Scene SceneID;
    public bool level1Cleared;
    public string KeybindLeft;
    public string KeybindRight;
    public string Jump; 
    public float HP;
    public int Coins;
}