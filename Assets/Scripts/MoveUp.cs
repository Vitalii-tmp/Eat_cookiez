using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float MoveSpeed;

    void Update()
    {
        transform.position += transform.up * MoveSpeed * 10 * Time.deltaTime;
    }
}
