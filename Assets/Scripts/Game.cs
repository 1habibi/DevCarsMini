using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private TicketManager _ticketManager;
    [SerializeField] private TicketView ticketView;
    [SerializeField] public int gameReward;
    [SerializeField] private int maxQuestions = 5;
    [SerializeField] private int countQuestins = 0;

    public void SetReward(TicketModel model, int reward)
    {
        if (reward == 10)
        {
            AudioManager.Instance.CorrectAnswer();
        }
        else if (reward == 0)
        {
            AudioManager.Instance.IncorrectAnswer();
        }
        gameReward += reward;
        if(countQuestins++ == maxQuestions)
        {
            MainSceneManager.Instance.SwapScene(SceneType.QUIZPLAY, SceneType.QUIZPLAYRESULTS);
            AudioManager.Instance.QuizPlayResults();
            TotalReward.Instance.SetReward(gameReward);
        }     
        else
            Begin(); 
        Debug.Log(countQuestins);
    }

    public void NewGame()
    {
        gameReward = 0;
        countQuestins = 0;
        if(_ticketManager == null)
        {
            _ticketManager = GetComponent<TicketManager>();
            _ticketManager.Parse();
            _ticketManager.MixIndexes();
            Begin();
        }    
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
