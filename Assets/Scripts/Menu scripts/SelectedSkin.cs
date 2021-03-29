using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedSkin : MonoBehaviour
{
    public int SkinNumber;
    public string StrSkinNumber;
    public int SkinPrice;
    public Text text;
    public Button button;
    private void Awake()
    {

        //check whether the skin is purchased

        //If not, check if the player can buy it and show the price of the skin
        int number = PlayerPrefs.GetInt("skin" + StrSkinNumber);
        if (number != SkinNumber)
        {
            if (SkinPrice > PlayerPrefs.GetInt("coins"))
                button.interactable = false;
            else
                button.interactable = true;
            text.text = "Купити за " + SkinPrice + " монет";
        }

        //If the skin is purchased, it is checked whether it is selected
        else
        {
            if (SkinNumber == PlayerPrefs.GetInt("skins"))
                text.text = "Поточний";
            if (SkinNumber != PlayerPrefs.GetInt("skins"))
                text.text = "Вибрати";
        }
    }
    public void selectedskin()
    {

        //buying a skin
        if (text.text == "Купити за " + SkinPrice + " монет" && button.GetComponent<Button>().interactable )
        {
            int coins = PlayerPrefs.GetInt("coins");
            coins -= SkinPrice;
            PlayerPrefs.SetInt("coins", coins);
            text.text = "Поточний";
            PlayerPrefs.SetInt("skins", SkinNumber);
            PlayerPrefs.SetInt("skin" + StrSkinNumber, SkinNumber);
        }

        //skin selection
        if (text.text == "Вибрати")
        {
            text.text = "Поточний";
            PlayerPrefs.SetInt("skins", SkinNumber);
        }
    }
}
