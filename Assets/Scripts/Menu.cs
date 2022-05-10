using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject storeMenu;
    [SerializeField] public GameObject levelsMenu;
    [SerializeField] public GameObject earnCoins;

    private StateMachine stateMachine;

    void Awake()
    {
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
    }

}
