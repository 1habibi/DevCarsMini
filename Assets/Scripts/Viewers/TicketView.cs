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




    public void CheckAnswer(TicketModel model)
    {
    
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
