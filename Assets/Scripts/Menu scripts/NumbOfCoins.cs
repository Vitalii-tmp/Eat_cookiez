using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbOfCoins : MonoBehaviour
{
    public Text CoinsText;
    void Start()
    {
        if (!PlayerPrefs.HasKey("coins"))
            PlayerPrefs.SetInt("coins", 0);
    }

    void Update()
    {
        CoinsText.text = PlayerPrefs.GetInt("coins").ToString();
    }
}
