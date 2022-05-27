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

    public static int skinID
    {
        get
        {
            return PlayerPrefs.GetInt("ID");
        }
        set
        {
            PlayerPrefs.SetInt("ID", value);
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
