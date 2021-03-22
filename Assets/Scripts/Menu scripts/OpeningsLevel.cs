using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningsLevel : MonoBehaviour
{
    public int[] ButtonLevel;
    public Button[] button;

    private void Start()
    {
        PlayerPrefs.SetInt("current_level", 25);
    }
    private void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            if (ButtonLevel[i] <= PlayerPrefs.GetInt("current_level"))
                button[i].interactable = true;
            else
                button[i].interactable = false;
        }
    }
}
