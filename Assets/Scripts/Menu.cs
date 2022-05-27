using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : Singleton<Menu>
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject storeMenu;
    [SerializeField] public GameObject levelsMenu;
    [SerializeField] public GameObject earnCoins;
    [SerializeField] public int totalReward;

    
    public StateMachine stateMachine { get; private set; }
    internal void SetReward(int gameReward)
    {
        totalReward += gameReward;
        User.coins = totalReward;
    }
    public override void Awake()
    {
        base.Awake();
        totalReward = User.coins;
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
    public void pushPlay()
    {
        stateMachine.SetState(StateMachine.State.LEVELS);
    }
    public void pushEarnCoins()
    {
        stateMachine.SetState(StateMachine.State.EARNCOINS);
        Game.Instance.NewGame();
    }
    public void pushFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

}
