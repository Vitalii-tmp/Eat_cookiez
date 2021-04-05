using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Music : MonoBehaviour
{
    public static GameObject lvlsound;

    private void Awake()
    {
        lvlsound = GameObject.FindGameObjectWithTag("sound");

        if (lvlsound == null)        
            lvlsound = (GameObject)Instantiate(Resources.Load("sound"));
         
        lvlsound.name = "sound";

        DontDestroyOnLoad(lvlsound);
    }
    public void MuteMusic()
    {
        if (lvlsound.GetComponent<AudioSource>().volume != 0)
            lvlsound.GetComponent<AudioSource>().volume = 0;
        else
            lvlsound.GetComponent<AudioSource>().volume = 0.3f;
    }
}

