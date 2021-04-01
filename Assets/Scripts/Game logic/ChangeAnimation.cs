using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Awake()
    {
        switch (PlayerPrefs.GetInt("skins"))
        {
            case 1:
                _animator.Play("Cow");
                break;

            case 2:
                _animator.Play("Pig");
                break;

            case 3:
                _animator.Play("Sheep");
                break;
        }
    } 
}
