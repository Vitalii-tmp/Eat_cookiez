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

        int number = PlayerPrefs.GetInt("skin" + StrSkinNumber);
        if (number != SkinNumber)
        {
            if (SkinPrice > PlayerPrefs.GetInt("coins"))
                button.interactable = false;
            else
                button.interactable = true;
            text.text = "Купити за " + SkinPrice + " монет";
        }         
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
        if (text.text == "Купити за " + SkinPrice + " монет" && button.GetComponent<Button>().interactable )
        {
            int coins = PlayerPrefs.GetInt("coins");
            coins -= SkinPrice;
            PlayerPrefs.SetInt("coins", coins);
            text.text = "Поточний";
            PlayerPrefs.SetInt("skins", SkinNumber);
            PlayerPrefs.SetInt("skin" + StrSkinNumber, SkinNumber);
        }
        if (text.text == "Вибрати")
        {
            text.text = "Поточний";
            PlayerPrefs.SetInt("skins", SkinNumber);
        }
    }
}
