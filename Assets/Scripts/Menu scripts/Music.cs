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
        var volume = lvlsound.transform.GetChild(0).gameObject.GetComponent<AudioSource>().volume;
        if (volume != 0)
            volume = 0;

        else
            volume = 0.3f;

    }
}

