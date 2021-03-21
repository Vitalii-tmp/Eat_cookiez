using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chydo : MonoBehaviour
{
  
    public void shydo()
    {
        PlayerPrefs.SetInt("skin1", 1);
        PlayerPrefs.SetInt("skin2", 0);
        PlayerPrefs.SetInt("skin3", 0);
        PlayerPrefs.SetInt("current_level", 25);
        PlayerPrefs.SetInt("coins", 100);
    }

}
