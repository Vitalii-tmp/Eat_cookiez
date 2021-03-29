using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerControler : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public float MoveSpeed;
    private Vector3 dir;
    private Vector3 lastDir;
    public Transform pl_transform;
    private bool reverse;

    public GameObject player;

    public bool ReturnReverse()
    {
        return reverse;
    } 

    public void respawn()
    {
       player.transform.position = Vector3.zero;
      
    }

    void Start()
    {
        dir = Vector3.up;
        lastDir = Vector3.up;
        reverse = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (reverse == false)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {

                if (eventData.delta.x > 0 && lastDir != Vector3.left)
                {
                    dir = Vector3.right;
                    lastDir = Vector3.right;
                    pl_transform.eulerAngles = new Vector3(0, 0, 90);
                }


                if (eventData.delta.x < 0 && lastDir != Vector3.right)
                {
                    dir = Vector3.left;
                    lastDir = Vector3.left;
                    pl_transform.eulerAngles = new Vector3(0, 0, 270);
                }

            }
            else
            {
                if (eventData.delta.y > 0)
                {
                    dir = Vector3.up;
                    lastDir = Vector3.up;
                    pl_transform.eulerAngles = new Vector3(0, 0, 180);
                }
            }
        }


        if (reverse == true)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {

                if (eventData.delta.x > 0 && lastDir != Vector3.right)
                {
                    dir = Vector3.left;
                    lastDir = Vector3.left;
                    pl_transform.eulerAngles = new Vector3(0, 0, 270);
                }


                if (eventData.delta.x < 0 && lastDir != Vector3.left)
                {
                    dir = Vector3.right;
                    lastDir = Vector3.right;
                    pl_transform.eulerAngles = new Vector3(0, 0, 90);
                }

            }
            else
            {
                if (eventData.delta.y > 0)
                {
                    dir = Vector3.up;
                    lastDir = Vector3.up;
                    pl_transform.eulerAngles = new Vector3(0, 0, 180);
                }
            }
        }
    }


    public void OnDrag(PointerEventData eventData)
    {

    }

    void FixedUpdate()
    {
        pl_transform.position += dir * MoveSpeed;
    }

    public Vector3 GetDir()
    {
        return dir; 
    }

    public void SetRevers(bool value)
    {
        reverse = value;
    }
}
