using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    private BoxCollider2D lineCollider;

    public GameObject mainCamera;
    public GameObject player;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && mainCamera.GetComponent<MoveUp>().GetIsJumping() == false && player.GetComponent<lineCheck>().GetOnLine() == false)
        {
            other.transform.position = Vector3.zero;
        }
    }




}
