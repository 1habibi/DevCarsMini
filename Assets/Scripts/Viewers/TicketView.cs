using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TicketView : MonoBehaviour
{
    // это указатели, а не данные. 
    [SerializeField]
    private Text description;

    [SerializeField]
    private Text[] Answers;

    [SerializeField] private TicketModel _model;

    [SerializeField] private int buttonIndex;
  
    public void FirstButton()
    {
        buttonIndex = 1;
        Debug.Log("Enter button= " + buttonIndex);
    }
    public void SecondButton()
    {
        buttonIndex = 2;
        Debug.Log("Enter button= " + buttonIndex);
    }
    public void ThirdButton()
    {
        buttonIndex = 3;
        Debug.Log("Enter button= " + buttonIndex);
    }
    public void FourthButton()
    {
        buttonIndex = 4;
        Debug.Log("Enter button= " + buttonIndex);
    }

    public void CheckAnswer(TicketModel model)
    {
        if (Answers[buttonIndex].ToString() == model.CorrectAnswer)
            Game.Instance.SetReward(model, 10);
        else
            Game.Instance.SetReward(model, 0);
    }

    public void SetTicketModel(TicketModel model)
    {
        _model = model;
        description.text = _model.Description;
        Debug.Log(description.text);
        int count = 0;
        foreach (string answer in model.Answers)
        {
            Answers[count].text = answer;
            if (++count > Answers.Length)
                break;
        }
    }
}
