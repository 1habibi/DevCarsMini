using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TicketManager : MonoBehaviour
{
    [SerializeField]
    private string pathTickets;

    [SerializeField]
    private GameMetaDataModels _models;

    void Awake()
    {
        Debug.Log("awake");
        Debug.Log("Application.persistentDataPath " + Application.dataPath);

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

    }

    public TicketModel GetModel(int index)
    {
        Debug.Log(index);
        return index >= _models.tickets.Length ? null : _models.tickets[index];
    }
}
