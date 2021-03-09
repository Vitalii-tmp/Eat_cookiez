using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveUp : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public float MoveSpeed;
    private Vector3 dir;
    private Vector3 lastDir;
    public Transform pl_transform;


    private float firstClickTime, timeBetweenClicks;
    private bool coroutineAllowed;
    private int clickCounter;

    public GameObject player;
    
    
    
    void Start()
    {
        dir = Vector3.up;
        lastDir = Vector3.up;
        firstClickTime = 0f;
        timeBetweenClicks = 0.2f;
        clickCounter = 0;
        coroutineAllowed = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y)){
            
            if (eventData.delta.x > 0 && lastDir!=Vector3.left)
            {
                dir = Vector3.right;
                lastDir = Vector3.right;
            }
            if (eventData.delta.x < 0 && lastDir != Vector3.right)
            {
                dir = Vector3.left;
                lastDir = Vector3.left;
            }
           
        }
        else
        {
            if (eventData.delta.y > 0 )
            {
                dir = Vector3.up;
                lastDir = Vector3.up;
              
            }
        }
    }



   
    public void OnDrag(PointerEventData eventData)
    {
       
    }

    void Update()
    {
        pl_transform.position += dir*MoveSpeed;


        if (Input.GetMouseButtonUp(0))
        {
            clickCounter += 1;
            if(clickCounter == 1 && coroutineAllowed)
            {
                firstClickTime = Time.time;
                StartCoroutine(DoubleClickDetection());
            }
        }
    }

    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while(Time.time<firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                player.GetComponent<BoxCollider2D>().enabled = false;
                yield return new WaitForSeconds(2);
                player.GetComponent<BoxCollider2D>().enabled = true;

            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
