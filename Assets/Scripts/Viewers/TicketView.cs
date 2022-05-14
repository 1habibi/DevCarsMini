using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TicketView : MonoBehaviour
{
    // ��� ���������, � �� ������. 
    [SerializeField]
    private Text description;

    [SerializeField]
    private Text[] Answers;

    [SerializeField] private TicketModel _model;

    [SerializeField] private int buttonIndex;
  
    public void FirstButton()
    {
        _checkAnswer(1);

    }
    public void SecondButton()
    {
        _checkAnswer(2);
    }
    public void ThirdButton()
    {
        _checkAnswer(3);
    }
    public void FourthButton()
    {
        _checkAnswer(4);
    }

    public void _checkAnswer(int answer)
    {
        Debug.Log("Enter button= " + answer);
        Game.Instance.SetReward(_model, answer == _model.CorrectAnswer ? _model.Reward : 0);
    }

    public void SetTicketModel(TicketModel model)
    {
        _model = model;
        description.text = _model.Description;
        Debug.Log(description.text);
        int count = 0;
        foreach (string answer in _model.Answers)
        {
            Answers[count].text = answer;
            if (count++ > Answers.Length)
                Debug.LogError("Слишком много вариантов вопросов.");
                break;
        }
    }
}
