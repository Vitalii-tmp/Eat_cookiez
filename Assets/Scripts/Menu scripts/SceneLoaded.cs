using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoaded : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("available_levels"))
            PlayerPrefs.SetInt("available_levels", 26);
        if (!PlayerPrefs.HasKey("current_level"))
                PlayerPrefs.SetInt("current_level", 26);

      /* 
        PlayerPrefs.SetInt("available_levels", 26);
        PlayerPrefs.SetInt("current_level", 26);
        PlayerPrefs.SetInt("skin1", 1);
        PlayerPrefs.SetInt("skin2", 0);
        PlayerPrefs.SetInt("skin3", 0);
        PlayerPrefs.SetInt("skin4", 0);
        PlayerPrefs.SetInt("skins", 1);
        PlayerPrefs.SetInt("coins", 0);
      */

        if (!PlayerPrefs.HasKey("skin1"))
            PlayerPrefs.SetInt("skin1", 1);

        if (!PlayerPrefs.HasKey("skin2"))
            PlayerPrefs.SetInt("skin2", 0);

        if (!PlayerPrefs.HasKey("skin3"))
            PlayerPrefs.SetInt("skin3", 0);

        if (!PlayerPrefs.HasKey("skin4"))
            PlayerPrefs.SetInt("skin4", 0);

        if (!PlayerPrefs.HasKey("skins"))
            PlayerPrefs.SetInt("skins", 1);
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
