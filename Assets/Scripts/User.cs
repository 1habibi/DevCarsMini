using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class User
{
    public static int coins 
    { 
        get 
        {
            return PlayerPrefs.GetInt("Coins");    
        } 
        set 
        {
            PlayerPrefs.SetInt("Coins", value);
            PlayerPrefs.Save();
        } 
    }

    public static int skin
    {
        get
        {
            return PlayerPrefs.GetInt("skin");
        }
        set
        {
            PlayerPrefs.SetInt("skin", value);
            PlayerPrefs.Save();
        }
    }

    public static string buySkin
    {
        get
        {
            return PlayerPrefs.GetString("buySkin");
        }
        set
        {
            PlayerPrefs.SetString("buySkin", value);
            PlayerPrefs.Save();
        }
    }

    public static int fuel
    {
        get
        {
            return PlayerPrefs.GetInt("Fuel");
        }
        set
        {
            PlayerPrefs.SetInt("Fuel", value);
            PlayerPrefs.Save();
        }
    }
}
