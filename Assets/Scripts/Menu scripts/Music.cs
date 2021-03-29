using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Music : MonoBehaviour
{
    public static GameObject lvlsound;

    //finding music
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
        if (lvlsound.transform.GetChild(0).gameObject.GetComponent<AudioSource>().volume != 0)
            lvlsound.transform.GetChild(0).gameObject.GetComponent<AudioSource>().volume = 0;

        else
            lvlsound.transform.GetChild(0).gameObject.GetComponent<AudioSource>().volume = 0.3f;

    }
}

