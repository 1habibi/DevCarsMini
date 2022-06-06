using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class PurchasedSkinsParser
{
    public static List<int> ParseToList(string value)
    {
        List<int> result = new List<int>();
        
        foreach (string s in value.Split(','))
        {
            if(!string.IsNullOrEmpty(s))
            {
                int x = Int32.Parse(s);
                result.Add(x);
            }      
        }
        return result;
    }

    public static string ParseToString(List<int> value)
    {
        string combinedString = string.Join(",", value.ToArray());
        return combinedString;
    }
}
