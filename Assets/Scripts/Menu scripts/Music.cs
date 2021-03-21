using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public AudioSource audio;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("music"))
            PlayerPrefs.SetInt("music", 1);
    }
    public void MusicPause()
    {
        if (PlayerPrefs.GetInt("music") == 1)
        {
            audio.volume = 0;
            PlayerPrefs.SetInt("music", 0);
        }
        else 
        {
            audio.volume = 0.3F;
            PlayerPrefs.SetInt("music", 1);
        }
    }
}
