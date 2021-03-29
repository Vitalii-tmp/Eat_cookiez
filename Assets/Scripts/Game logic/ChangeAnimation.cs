using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void Awake()
    {
        switch (PlayerPrefs.GetInt("skins"))
        {
            case 1:
                animator.Play("Cow");
                break;

            case 2:
                animator.Play("Pig");
                break;

            case 3:
                animator.Play("Sheep");
                break;
            case 4:
                animator.Play("Osel");
                break;
        }
    } 
}
