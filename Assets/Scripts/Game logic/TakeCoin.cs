using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoin : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            audio.Play();

            Destroy(other.gameObject);

            int coins = PlayerPrefs.GetInt("coins");
            coins++;
            PlayerPrefs.SetInt("coins", coins);
        }
    }
}
