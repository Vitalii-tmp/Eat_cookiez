using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lineCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if player touch border on road load die scene
        if (other.tag == "Line")
        {
            SceneManager.LoadScene(23);
        }
    }
}
