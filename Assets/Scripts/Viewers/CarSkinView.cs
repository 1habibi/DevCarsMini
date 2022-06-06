using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSkinView : MonoBehaviour
{
    [SerializeField] private int ActiveSkin;
    [SerializeField] private ShopView shopView;
    [SerializeField] private int carFuel;

    [SerializeField] private GameObject buy;
    [SerializeField] private GameObject select;

    [SerializeField] private int cost;
    [SerializeField] private Text costText;


    private Image spr;

    private void Awake()
    {
        if (spr == null)
            spr = GetComponent<Image>();
        if (costText == null)
            costText = GetComponent<Text>();
        Sprite carSkin = CarSkinResourceManager.Instance.skins[ActiveSkin];
        spr.sprite = carSkin;
        costText.text = cost.ToString();
    }

    public void OnShow(List<int> purchasedSkins)
    { 
        foreach(int i in purchasedSkins)
        {
            if (i == ActiveSkin)
            {
                buy.SetActive(false);
                select.SetActive(true);
                costText.gameObject.SetActive(false);
                break;
            }
        }
    }

    public void BuySkin()
    {
        if (User.coins >= 1)
        {
            User.coins -= cost;
            // User.fuel = carFuel;
            Debug.Log("carfuel =" + User.fuel);
            shopView.UpdateReward();
            Debug.Log(User.buySkin);
            List<int> purchasedSkins = PurchasedSkinsParser.ParseToList(User.buySkin);
            Debug.Log(purchasedSkins);
            purchasedSkins.Add(ActiveSkin);
            Debug.Log(PurchasedSkinsParser.ParseToString(purchasedSkins));
            User.buySkin = PurchasedSkinsParser.ParseToString(purchasedSkins);

            buy.SetActive(false);
            costText.gameObject.SetActive(false);
            ApplySkin();
        } 
    }

    public void ApplySkin()
    {
        AudioManager.Instance.TapUIButtons();
        User.fuel = carFuel;
        User.skin = ActiveSkin;
    }

}
