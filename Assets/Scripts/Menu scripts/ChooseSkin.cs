using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSkin : MonoBehaviour
{
    public GameObject Player;
    public Sprite DefaultSkin;
    public Sprite Skin1;
    public Sprite Skin2;
    public Sprite Skin3;
    void Start()
    {
        switch (PlayerPrefs.GetInt("skins"))
        {
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = DefaultSkin;
            break;

            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = Skin1;
                break;
            case 3:
                Player.GetComponent<SpriteRenderer>().sprite = Skin2;
                break;
            case 4:
                Player.GetComponent<SpriteRenderer>().sprite = Skin3;
                break;
        }
    }
}
