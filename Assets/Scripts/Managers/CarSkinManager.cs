using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSkinManager : MonoBehaviour
{
    private SpriteRenderer spr;
    private Sprite carSkin;
    public void Initialization()
    {
        if (spr == null)
        {
            spr = GetComponent<SpriteRenderer>();
            Debug.Log("GetComponent<SpriteRenderer>();");
        }
    }

    public void SetSkin()
    {
        int skin;
        if (User.buySkin == "")
        {
             skin = 0;
        }
        else
             skin = User.skin;
        Debug.Log("User.skin = " + skin);
        carSkin = CarSkinResourceManager.Instance.skins[skin];
        spr.sprite = carSkin;
    }

}

