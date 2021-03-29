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
        //open complited levels in menu  
        for (int i = 0; i < 9; i++)
        {
            //depend on level status open or close lvl
            if (ButtonLevel[i] <= PlayerPrefs.GetInt("available_levels"))
                button[i].interactable = true;
            else
                button[i].interactable = false;
        }
    }
}
