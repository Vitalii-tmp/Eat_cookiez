using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumbOfCoins : MonoBehaviour
{
    public Text CoinsText;
    void Start()
    {
        if (!PlayerPrefs.HasKey("current_level"))
            PlayerPrefs.SetInt("current_level", 25);
        PlayerPrefs.SetInt("skin1", 1);
        PlayerPrefs.SetInt("skins", 1);
        PlayerPrefs.SetInt("current_level", 25);
        if (!PlayerPrefs.HasKey("coins"))
            PlayerPrefs.SetInt("coins", 0);
    }

    void Update()
    {
        CoinsText.text = PlayerPrefs.GetInt("coins").ToString();
    }
}
