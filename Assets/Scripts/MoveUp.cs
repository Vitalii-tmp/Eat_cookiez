using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MoveUp : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public float MoveSpeed;
    private Vector3 dir;
    public Transform pl_transform;
    void Start()
    {
        dir = Vector3.up;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y)){
            
            if (eventData.delta.x > 0)
            {
                dir = Vector3.right;
            }
            if (eventData.delta.x < 0)
            {
                dir = Vector3.left;
            }
           
        }
        else
        {
            if (eventData.delta.y > 0)
            {
                dir = Vector3.up;
            }
        }
    }

   
    public void OnDrag(PointerEventData eventData)
    {
       
    }

    void Update()
    {
        pl_transform.position += dir*MoveSpeed;
    }
}
