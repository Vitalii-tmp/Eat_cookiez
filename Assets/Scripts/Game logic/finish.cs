using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour

{
    public int CurrentLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerPrefs.SetInt("current_level", CurrentLevel + 1);
            SceneManager.LoadScene(24);
        }
    }
}
