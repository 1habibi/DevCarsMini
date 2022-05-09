using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[4];
}

public class QuizScript : MonoBehaviour
{
    [SerializeField]
    private string pathTickets;
    
    GameObject buttonStart;
    GameObject HeadQuiz;
   
    public Text Qtext; // текст вопросов
    public Text PressSpace;

    public Text[] answersText; // текст ответов на кнопках
    public QuestionList[] questions;

    public Sprite[] TFIcons = new Sprite[2];
    public Image TFIcon;

    List<object> qList;
    QuestionList crntQ;
    int randQ;

    private void Awake()
    {
        Debug.Log("awake");
        Debug.Log("Application.persistentDataPath " + Application.dataPath);
    }
    public void Start() // Отключение вопросов до нажатия кнопки Start
    {
        HeadQuiz = GameObject.Find("Quiz");
        TFIcon.gameObject.SetActive(false);
        PressSpace.gameObject.SetActive(false);
        HeadQuiz.SetActive(false);
    }
    public void PressStartButton() // Отключение кнопки старт после ее нажатия
    {
        buttonStart = GameObject.Find("StartButton");
        buttonStart.SetActive(false);
        OnClickStart();
    }
    public void OnClickStart() // создание листа с вопросами и ответами
    {
        qList = new List<object>(questions);
        questGenerate();
    }
    void questGenerate() 
    {
        Parse();
        PressSpace.gameObject.SetActive(false);
        TFIcon.gameObject.SetActive(false);
        HeadQuiz.SetActive(true);

        if (qList.Count > 0)
        {
            randQ = Random.Range(0, qList.Count);
            crntQ = qList[randQ] as QuestionList;
            Qtext.text = crntQ.question;
            List<string> answerslist = new List<string>(crntQ.answers);
            for (int i = 0; i < crntQ.answers.Length; i++)
            {
                int rand = Random.Range(0, answerslist.Count);
                answersText[i].text = answerslist[rand];
                answerslist.RemoveAt(rand);
            }
        }
        else
        {
            print("Вы прошли игру");
        }
        
    }
    public void answersBttns(int index)
    {
       if (answersText[index].text.ToString() == crntQ.answers[0])
       {
            TFIcon.sprite = TFIcons[0];
            TFIcon.gameObject.SetActive(true);
            PressSpace.gameObject.SetActive(true);
        }
       else
       {
            TFIcon.sprite = TFIcons[1];
            TFIcon.gameObject.SetActive(true);
            PressSpace.gameObject.SetActive(true);
       }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            qList.RemoveAt(randQ);
            questGenerate();
        }  
    }

    public void Parse()
    {
        string path = Application.dataPath + pathTickets;
        StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        reader.Close();
        Debug.Log(json);
        questions = JsonUtility.FromJson<QuestionList[]>(json);
    }
}


