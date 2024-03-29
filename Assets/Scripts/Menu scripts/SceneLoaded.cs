﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoaded : MonoBehaviour
{
    //opening the first level and skin
    private void Start()
    {
        if (!PlayerPrefs.HasKey("available_levels"))
            PlayerPrefs.SetInt("available_levels", 25);
        if (!PlayerPrefs.HasKey("current_level"))
                PlayerPrefs.SetInt("current_level", 25);
        if (!PlayerPrefs.HasKey("skin1"))
            PlayerPrefs.SetInt("skin1", 1);
    }

    public void SceneLoad(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadCurrentLevel()
    {
        int prevlvl = PlayerPrefs.GetInt("current_level");
        SceneManager.LoadScene(prevlvl);
    }

    public void LoadTheLatestAvailableLevel()
    {
        int prevlvl = PlayerPrefs.GetInt("available_levels");
        SceneManager.LoadScene(prevlvl);
    }

}
