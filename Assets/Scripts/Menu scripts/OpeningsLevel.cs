using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningsLevel : MonoBehaviour
{
    public int[] ButtonLevel;
    public Button[] button;
    private void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            button[i].interactable = ButtonLevel[i] <= PlayerPrefs.GetInt("available_levels");
        }
    }
}
