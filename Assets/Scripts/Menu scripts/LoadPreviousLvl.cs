using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPreviousLvl : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("current_level"))
            PlayerPrefs.SetInt("current_level", 2);
    }
    public void loadpreviouslevel()
    {
        int prevlvl = PlayerPrefs.GetInt("current_level");
        SceneManager.LoadScene(prevlvl);
    }
}
