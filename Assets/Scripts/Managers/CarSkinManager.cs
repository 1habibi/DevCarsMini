using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSkinManager : MonoBehaviour
{
    [SerializeField] protected Sprite[] skins;
    [SerializeField] private int skinIndex;

    public Sprite SetSkin(int index)
    {
        return skins[index];
    }
   
    public void SetFirstIndex()
    {
        skinIndex = 1;
    }
    public void SetSecondIndex()
    {
        skinIndex = 2;
    }
}

