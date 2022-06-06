using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalReward : Singleton<TotalReward>
{
    [SerializeField] public int totalReward;
    internal void SetReward(int gameReward)
    {
        totalReward += gameReward;
        User.coins = totalReward;
        Debug.Log("total reward= " + totalReward + " user info = " + User.coins);
    }
    public override void Awake()
    {
        base.Awake();
        totalReward = User.coins;
    }
}
