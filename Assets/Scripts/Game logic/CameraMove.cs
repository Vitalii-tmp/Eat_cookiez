using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject cameramove;
    public Camera MainCamera;
    public bool SelfMovingAnimation;
    private bool move;
    private Animator anim;
    private void Start()
    {
        anim = MainCamera.GetComponent<Animator>();
        move = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "CameraIventBegin")
        {
            anim.Play("CameraIventBegin");
            if (SelfMovingAnimation)
                move = false;
        }
        if (other.tag == "CameraIventBegin2")
        {
            anim.Play("CameraIventBegin2");
            if (SelfMovingAnimation)
                move = false;
        }
        if (other.tag == "CameraIventBegin3")
        {
            anim.Play("CameraIventBegin3");
            if (SelfMovingAnimation)
                move = false;
        }
        if (other.tag == "CameraIventEnd")
        {
            anim.Play("CameraIventEnd");
            move = true;
        }
    }
   void Update()
    {
        if (move)
            cameramove.transform.position = new Vector3(transform.position.x - 0.73f, transform.position.y, 0);
    }
}
