using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse : MonoBehaviour
{
    public GameObject panel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            panel.GetComponent<PlayerControler>().SetRevers(!panel.GetComponent<PlayerControler>().ReturnReverse());
        }
    }
}
