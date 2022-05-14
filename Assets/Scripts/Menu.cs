using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : Singleton<Menu>
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject storeMenu;
    [SerializeField] public GameObject levelsMenu;
    [SerializeField] public GameObject earnCoins;
    [SerializeField] public int totalReward;

    public StateMachine stateMachine { get; private set; }

    public override void Awake()
    {
        base.Awake();
        LoadGame();
        stateMachine = new StateMachine(this);
        stateMachine.SetState(StateMachine.State.MENU);
    }
    public void pushStore()
    {
        stateMachine.SetState(StateMachine.State.STORE);
    }
    public void pushBacktoMenu()
    {
        stateMachine.SetState(StateMachine.State.MENU);
    }

    internal void SetReward(int gameReward)
    {
        totalReward += gameReward;
        SaveGame();
    }
    public void pushPlay()
    {
        stateMachine.SetState(StateMachine.State.LEVELS);
    }
    public void pushEarnCoins()
    {
        stateMachine.SetState(StateMachine.State.EARNCOINS);
    }
    public void SaveGame()
    {
        PlayerPrefs.SetInt("Coins", totalReward);
        PlayerPrefs.Save();
    }
    void LoadGame()
    {
        totalReward = PlayerPrefs.GetInt("Coins");
    }
}
