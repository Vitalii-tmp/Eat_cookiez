using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour

{

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.transform.position = Vector3.zero;
        }
    }
}
