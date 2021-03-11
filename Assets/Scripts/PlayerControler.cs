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


    //private float firstClickTime, timeBetweenClicks;
    //private int clickCounter;

    public GameObject player;

    //private bool isJumping;

    public void respawn()
    {
       player.transform.position = Vector3.zero;
        pl_transform.eulerAngles = new Vector3(0, 0, 180);
        dir = Vector3.up;
        lastDir = Vector3.up;
    }
    void Start()
    {
        dir = Vector3.up;
        lastDir = Vector3.up;
        //firstClickTime = 0f;
        //timeBetweenClicks = 0.2f;
        //clickCounter = 0;
        //isJumping = false;

        //StartCoroutine(DoubleClickDetection());

    }

    public void OnBeginDrag(PointerEventData eventData)
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




    public void OnDrag(PointerEventData eventData)
    {

    }

    void Update()
    {
        pl_transform.position += dir * MoveSpeed;

        //if (Vector3.right == dir)
        //{
        //    Camera.main.transform.eulerAngles = new Vector3(0, 0, 90);
        //}
        //if (Vector3.left == dir)
        //{
        //    Camera.main.transform.eulerAngles = new Vector3(0, 0, -90);
        //}
        //if (Vector3.up == dir)
        //{
        //    Camera.main.transform.eulerAngles = new Vector3(0, 0, 0);
        //}
    }

    //private IEnumerator DoubleClickDetection()
    //{

    //    while (true)
    //    {
    //        if (Input.GetMouseButtonUp(0))
    //        {
    //            clickCounter += 1;
    //            if (clickCounter == 1)
    //            {
    //                firstClickTime = Time.time;

    //            }
               
    //            if (clickCounter == 2 && Time.time - firstClickTime <= timeBetweenClicks)
    //            {
    //                Debug.Log("double tap");
    //                isJumping = true;
    //                player.GetComponent<BoxCollider2D>().enabled = false;
    //                yield return new WaitForSeconds(0.5f);
    //                player.GetComponent<BoxCollider2D>().enabled = true;
    //                isJumping = false;
    //                Debug.Log(player.GetComponent<BoxCollider2D>().enabled);
    //                clickCounter = 0;

    //            }
    //            if (Time.time - firstClickTime > timeBetweenClicks)
    //            {
    //                clickCounter = 0;
    //                firstClickTime = 0f;
    //            }
    //        }
    //        yield return null;

    //    }
       
       

      

    //}

    //public bool GetIsJumping()
    //{
    //    return isJumping;
    //}
    public Vector3 GetDir()
    {
        return dir; 
    }
}
