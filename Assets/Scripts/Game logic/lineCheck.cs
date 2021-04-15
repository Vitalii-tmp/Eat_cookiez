using Assets.FUGAS.Ads.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lineCheck : MonoBehaviour
{
    public static int dieCounter = 0;
    public static bool addClosed;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            addClosed = false;
            dieCounter++;
            GameObject.FindGameObjectWithTag("InterstitialAd").GetComponent<InterstitialAdScript>().ShowAd();
            StartCoroutine(LoadAfterAd());
           
        }
    }

    private IEnumerator LoadAfterAd()
    {
        while (Time.timeScale == 0)
        {
            yield return null;
        }
        SceneManager.LoadScene("DieMenu");
    }
}
