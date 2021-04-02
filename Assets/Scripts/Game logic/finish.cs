using System.Collections;
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
        if (collision.tag == "Player")
        {
            if (PlayerPrefs.GetInt("available_levels") == PlayerPrefs.GetInt("current_level"))
            {
                PlayerPrefs.SetInt("available_levels", CurrentLevel + 1);
                SceneManager.LoadScene("Level finish");
            }
        }
    }
}
