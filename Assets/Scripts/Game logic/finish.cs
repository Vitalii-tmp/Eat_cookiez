﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public int CurrentLevel;
    private void Start()
    {
        PlayerPrefs.SetInt("current_level", CurrentLevel);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if player touch finish collider open next lvl and load victory scene
        if (collision.tag == "Player")
        {
            if (45 == PlayerPrefs.GetInt("current_level"))
                PlayerPrefs.SetInt("available_levels", CurrentLevel);
            if (PlayerPrefs.GetInt("available_levels") == PlayerPrefs.GetInt("current_level"))
                PlayerPrefs.SetInt("available_levels", CurrentLevel + 1);
            SceneManager.LoadScene(24);
        }
    }
}
