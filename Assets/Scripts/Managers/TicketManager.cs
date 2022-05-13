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
    
    [SerializeField]
    private int active_index = 0;
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
            randomIndexes.Add(i);
        
        Begin();
    }
    
    public void Begin()
    {
        active_index = 0;
        Debug.Log("randomIndexes " + randomIndexes.Count);

        for (int i = 0; i < randomIndexes.Count; i++)
        {
            int one = Random.Range(0, randomIndexes.Count);
            int two = Random.Range(0, randomIndexes.Count);
            int tmp = randomIndexes[one];
            if (one == two)
                continue;
            Debug.Log("one " + one);
            Debug.Log("two  " + two);
            randomIndexes[one] = randomIndexes[two];
            randomIndexes[two] = tmp;
        }
        Debug.Log(randomIndexes.Count);
    }
    public TicketModel GetModel(int index = -1)
    {
        TicketModel model = null;
        Debug.Log(index);
        if (index >= 0){
            model = index >= _models.tickets.Length ? null : _models.tickets[randomIndexes[active_index]];
            active_index++;
        }
        else {
            model = _models.tickets[randomIndexes[active_index++]];
            if (active_index >= _models.tickets.Length)
                Begin();
        }
        return model;
    }
}
