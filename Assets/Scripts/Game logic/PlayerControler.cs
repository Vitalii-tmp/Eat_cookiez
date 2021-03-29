using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerControler : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    //player speed
    public float MoveSpeed;

    //current direction variable
    private Vector3 dir;
    //last direction variable
    private Vector3 lastDir;

    //revers flag
    private bool reverse;

    //player
    public GameObject player;

    //Getter for revers
    public bool ReturnReverse()
    {
        return reverse;
    }

    void Start()
    {
        //config on start 
        dir = Vector3.up;
        lastDir = Vector3.up;
        reverse = false;
    }


    //method for swipes
    //depend on swipe direction change dir, last dir, and andle of player
    public void OnBeginDrag(PointerEventData eventData)
    {
        //without revers 
        if (reverse == false)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {
                //swipe right
                if (eventData.delta.x > 0 && lastDir != Vector3.left)
                {
                    dir = Vector3.right;
                    lastDir = Vector3.right;
                    player.transform.eulerAngles = new Vector3(0, 0, 90);
                }

                //swipe left
                if (eventData.delta.x < 0 && lastDir != Vector3.right)
                {
                    dir = Vector3.left;
                    lastDir = Vector3.left;
                   player.transform.eulerAngles = new Vector3(0, 0, 270);
                }

            }
            else
            {
                //swipe up
                if (eventData.delta.y > 0)
                {
                    dir = Vector3.up;
                    lastDir = Vector3.up;
                   player.transform.eulerAngles = new Vector3(0, 0, 180);
                }
            }
        }

        //with revers 
        if (reverse == true)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {
                //swipe right
                if (eventData.delta.x > 0 && lastDir != Vector3.right)
                {
                    dir = Vector3.left;
                    lastDir = Vector3.left;
                   player.transform.eulerAngles = new Vector3(0, 0, 270);
                }

                //swipe left
                if (eventData.delta.x < 0 && lastDir != Vector3.left)
                {
                    dir = Vector3.right;
                    lastDir = Vector3.right;
                   player.transform.eulerAngles = new Vector3(0, 0, 90);
                }

            }
            else
            {
                //swipe up
                if (eventData.delta.y > 0)
                {
                    dir = Vector3.up;
                    lastDir = Vector3.up;
                   player.transform.eulerAngles = new Vector3(0, 0, 180);
                }
            }
        }
    }


    public void OnDrag(PointerEventData eventData)
    {

    }

    //move player depend on direction
    void FixedUpdate()
    {
        player.transform.position += dir * MoveSpeed;
    }

    //getter for direction
    public Vector3 GetDir()
    {
        return dir;
    }

    //set revers
    public void SetRevers(bool value)
    {
        reverse = value;
    }
}
