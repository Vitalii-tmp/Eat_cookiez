using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoin : MonoBehaviour
{
    public AudioSource audio;

    //When interacting with a coin, the following steps are performed
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            audio.Play();    //plays the appropriate sound

            Destroy(other.gameObject);   //the coin is destroyed

            //increase the number of coins in the account by 1
            int coins = PlayerPrefs.GetInt("coins");
            coins++;
            PlayerPrefs.SetInt("coins", coins);
        }
    }
}
