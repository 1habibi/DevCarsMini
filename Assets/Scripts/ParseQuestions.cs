using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ParseQuestions : MonoBehaviour
{

    [SerializeField]
    public QuestionList _models;

    public void Parse()
    {
        string path = Application.streamingAssetsPath + "/" + "tickets.json";
        StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        reader.Close();
        Debug.Log(json);
        _models = JsonUtility.FromJson<QuestionList>(json);
        Debug.Log(_models);
    }

}
