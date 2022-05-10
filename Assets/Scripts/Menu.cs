using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject storeMenu;
    [SerializeField] public GameObject levelsMenu;
    [SerializeField] public GameObject earnCoins;

    private StateMachine StateMachine;

    void Awake()
    {
        StateMachine.SetState(StateMachine.State.MENU);
    }
    public void pushStore()
    {
        StateMachine.SetState(StateMachine.State.STORE);
    }
    public void pushBacktoMenu()
    {
        StateMachine.SetState(StateMachine.State.MENU);
    }
    public void pushPlay()
    {
        StateMachine.SetState(StateMachine.State.LEVELS);
    }
    public void pushEarnCoins()
    {
        StateMachine.SetState(StateMachine.State.EARNCOINS);
    }

}
