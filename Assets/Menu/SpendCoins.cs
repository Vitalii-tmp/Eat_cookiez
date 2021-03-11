using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpendCoins : MonoBehaviour
{
    public void spendcoins(int value)
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= value)
        {
            coins -= value;
            PlayerPrefs.SetInt("coins", coins);
        }
    }
}
