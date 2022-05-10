using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Collections;

public class TicketManager : MonoBehaviour
{
    [SerializeField]
    private string pathTickets;

    [SerializeField]
    private List<int> randomIndexes;  

    [SerializeField]
    private GameMetaDataModels _models;

    void Awake()
    {
        Debug.Log("awake");
        Debug.Log("Application.persistentDataPath " + Application.dataPath);
        randomIndexes = new List<int>();
    }

    public void Parse()
    {
        string path = Application.dataPath + pathTickets;
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();
        reader.Close();
        Debug.Log(json);
        _models = JsonUtility.FromJson<GameMetaDataModels>(json);
        Debug.Log(_models);

        for (int i = 0; i < _models.tickets.Length; i++)
        {
            randomIndexes.Add(i);
        }
    }
    
    public void Begin()
    {
        randomIndexes.Clear();
         
        //for (int i = 0; i < _models.tickets.Length; i++)
        //{
        //    int one = Random.Range(0, _models.tickets.Length + 1);
        //    int two = Random.Range(0, _models.tickets.Length + 1);
        //    int tmp = _models.tickets[one];
        //}

        Debug.Log(randomIndexes);
      
    }
    public TicketModel GetModel(int index)
    {
        Debug.Log(index);
        return index >= _models.tickets.Length ? null : _models.tickets[index];
    }
}
