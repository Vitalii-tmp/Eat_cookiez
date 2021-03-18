using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpace : MonoBehaviour
{
    public int CurrentLevel;
    public GameObject player;

    private void Start()
    {
        PlayerPrefs.SetInt("current_level", CurrentLevel);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && player.GetComponent<lineCheck>().GetOnLine() == false)
        {
            SceneManager.LoadScene(23);
           // other.transform.position = Vector3.zero;
        }
    }




}
