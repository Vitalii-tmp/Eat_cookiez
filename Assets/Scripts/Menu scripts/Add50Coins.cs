using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add50Coins : MonoBehaviour
{
    public void Add_50_Coins()
    {
        int coins = PlayerPrefs.GetInt("coins");
        coins = 100;
        PlayerPrefs.SetInt("coins", coins);
    }
}
