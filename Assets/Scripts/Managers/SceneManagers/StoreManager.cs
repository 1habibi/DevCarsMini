using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : GameScreen
{
    private ShopView shopView = null;
    [SerializeField] private PurchasedSkinsManager purchasedSkinsManager;
    public override void OnShow()
    {
        if (shopView == null)
            shopView = GetComponent<ShopView>();
        shopView.UpdateReward();
        Debug.Log(User.buySkin);
        purchasedSkinsManager.GetListOfPurchasedSkin();
        purchasedSkinsManager.OnShow();
    }
}
