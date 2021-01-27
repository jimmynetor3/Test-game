using System;
using UnityEngine;

[Serializable]
public class playerdata
{
    public int HP;
    public int Coins;

    public playerdata()
    {
        HP = PlayerDies.HP;
        Coins = CollectCoin.coins;
        // levelsCleared = new[]
        // {
        //     levelsCleared[1] = false,
        //     levelsCleared[2] = false
        // };
    }
}
