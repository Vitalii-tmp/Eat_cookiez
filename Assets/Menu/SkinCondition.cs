using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinCondition : MonoBehaviour
{
    public GameObject Player;
    public Sprite NewSprite;
   public void ChangeTexture()
    {
        Player.GetComponent<SpriteRenderer>().sprite = NewSprite;
    }
}
