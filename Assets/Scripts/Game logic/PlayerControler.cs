using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerControler : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public float MoveSpeed;
    public GameObject player;

    private Vector3 _direction;
    private Vector3 _lastDirection;
    private readonly Vector3 _angleRight = new Vector3(0, 0, 90),
        _angleLeft = new Vector3(0, 0, 270), _angleForward = new Vector3(0, 0, 180);
    private bool _reverse;

    public bool ReturnReverse()
    {
        return _reverse;
    } 

    public void respawn()
    {
       player.transform.position = Vector3.zero;
    }

    void Start()
    {
        _direction = Vector3.up;
        _lastDirection = Vector3.up;
        _reverse = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (_reverse == false)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {

                if (eventData.delta.x > 0 && _lastDirection != Vector3.left)
                {
                    _direction = Vector3.right;
                    _lastDirection = Vector3.right;
                    player.transform.eulerAngles = _angleRight;
                }


                if (eventData.delta.x < 0 && _lastDirection != Vector3.right)
                {
                    _direction = Vector3.left;
                    _lastDirection = Vector3.left;
                    player.transform.eulerAngles = _angleLeft;
                }
            }
            else
            {
                if (eventData.delta.y > 0)
                {
                    _direction = Vector3.up;
                    _lastDirection = Vector3.up;
                    player.transform.eulerAngles = _angleForward;
                }
            }
        }


        if (_reverse == true)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {

                if (eventData.delta.x > 0 && _lastDirection != Vector3.right)
                {
                    _direction = Vector3.left;
                    _lastDirection = Vector3.left;
                    player.transform.eulerAngles = _angleLeft;
                }


                if (eventData.delta.x < 0 && _lastDirection != Vector3.left)
                {
                    _direction = Vector3.right;
                    _lastDirection = Vector3.right;
                    player.transform.eulerAngles = _angleRight;
                }

            }
            else
            {
                if (eventData.delta.y > 0)
                {
                    _direction = Vector3.up;
                    _lastDirection = Vector3.up;
                    player.transform.eulerAngles = _angleForward;
                }
            }
        }
    }


    void FixedUpdate()
    {
        player.transform.position += _direction * MoveSpeed;
    }

    public Vector3 GetDir()
    {
        return _direction; 
    }

    public void SetRevers(bool value)
    {
        _reverse = value;
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
