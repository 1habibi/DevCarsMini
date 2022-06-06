using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopView : MonoBehaviour
{
    [SerializeField] private Text totalReward;

    public void UpdateReward()
    {
        totalReward.text = User.coins.ToString();
    }

}
