using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasedSkinsManager : MonoBehaviour
{
    [SerializeField] public List<int> purchasedSkins;
    [SerializeField] public List<CarSkinView> carSkinViews;
    private bool enableToAdd = false;   
    
    public void OnShow()
    {
        foreach(CarSkinView car in carSkinViews)
        {
            car.OnShow(purchasedSkins);
        }
    }
    public void ResetList()
    {
        purchasedSkins.Clear();
        User.buySkin = "";
    }
    public void GetListOfPurchasedSkin()
    {
       if (User.buySkin != null && User.buySkin != "")
       {
            purchasedSkins = PurchasedSkinsParser.ParseToList(User.buySkin);
       }
    }

    //public void AddPurchasedSkinToList(int value)
    //{
    //    if (purchasedSkins.Count == 0)
    //    {
    //        purchasedSkins.Add(value);
    //        User.buySkin = PurchasedSkinsParser.ParseToString(purchasedSkins);
    //        Debug.Log("buyskn = " + User.buySkin);
    //    }
    //    else
    //    {
    //        for (int i = 0; i < purchasedSkins.Count; i++)
    //        {
    //            if (purchasedSkins[i] != value)
    //            {
    //                enableToAdd = true;
    //                Debug.Log(enableToAdd);
    //            }
    //            else
    //            {
    //                enableToAdd = false;
    //                Debug.Log(enableToAdd);
    //                break;
    //            }
    //        }
    //        if (enableToAdd == true)
    //        {
    //            purchasedSkins.Add(value);
    //            User.buySkin = PurchasedSkinsParser.ParseToString(purchasedSkins);
    //            Debug.Log("buyskn = " + User.buySkin);
    //        }
    //    }
    //}
}

