using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("skins") == 1) 
        {
            animator.SetBool("Cow", true);
            animator.SetBool("Pig", false);
            animator.SetBool("Sheep", false);
        }
        if (PlayerPrefs.GetInt("skins") == 2)
        {
            animator.SetBool("Cow", false);
            animator.SetBool("Pig", true);
            animator.SetBool("Sheep", false);
        }
        if (PlayerPrefs.GetInt("skins") == 3)
        {
            animator.SetBool("Cow", false);
            animator.SetBool("Pig", false);
            animator.SetBool("Sheep", true);
        }
    }

   
}
