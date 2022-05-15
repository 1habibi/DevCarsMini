using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : Singleton<Game>
{
    [SerializeField] private TicketManager _ticketManager;
    [SerializeField] private TicketView ticketView;
    [SerializeField] public int gameReward;
    [SerializeField] private int maxQuestions = 5;
    [SerializeField] private int countQuestins = 0;


    public void SetReward(TicketModel model, int reward)
    {
        gameReward += reward;
        if(countQuestins++ == maxQuestions)
        {
            Menu.Instance.stateMachine.SetState(StateMachine.State.MENU);
            Menu.Instance.SetReward(gameReward);
        }     
        else
            Begin(); 
        Debug.Log(countQuestins);
    }

    public void NewGame()
    {
        gameReward = 0;
        countQuestins = 0;
        _ticketManager.MixIndexes();
        Begin();
    }
    void Start()
    {
        _ticketManager = GetComponent<TicketManager>();
        _ticketManager.Parse();
        _ticketManager.MixIndexes();
        Debug.Log(_ticketManager);
        Begin();
    }
    public void Begin()
    {
        TicketModel model = _ticketManager.GetModel();
        if (model != null)
        {
            ticketView.SetTicketModel(model);
        }     
    }
}
