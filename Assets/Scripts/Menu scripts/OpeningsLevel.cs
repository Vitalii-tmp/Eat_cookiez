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
            if (ButtonLevel[i] <= PlayerPrefs.GetInt("available_levels"))
                button[i].interactable = true;
            else
                button[i].interactable = false;
        }
    }
}
