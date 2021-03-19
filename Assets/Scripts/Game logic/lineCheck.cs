using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineCheck : MonoBehaviour
{
    // Start is called before the first frame update
    private bool onLine=true;

    //private void Start()
    //{
    //    onLine = true;
    //}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Line")
        {
            onLine = true;
            Debug.Log("on line");
        }
        else
        {
            onLine = false;
            Debug.Log("false");
        }
    }

    public bool GetOnLine()
    {
        return onLine;
    }

}
