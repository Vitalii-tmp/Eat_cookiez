using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbOfCoins : MonoBehaviour
{
    //text with coins
    public Text CoinsText;
    void Start()
    {
        
        if (!PlayerPrefs.HasKey("coins"))
            PlayerPrefs.SetInt("coins", 0);
    }

    void Update()
    {
        //write current numb of coins 
        CoinsText.text = PlayerPrefs.GetInt("coins").ToString();
    }
}
