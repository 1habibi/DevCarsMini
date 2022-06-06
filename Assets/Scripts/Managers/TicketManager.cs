using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Collections;

public class TicketManager : MonoBehaviour
{
    [SerializeField]
    private string pathTickets;

    [SerializeField]
    private List<int> randomIndexes = new List<int>();

    [SerializeField]
    private GameMetaDataModels _models;
    
    [SerializeField]
    private int active_index = 0;
    void Awake()
    {
        Debug.Log("awake");
        Debug.Log("Application.persistentDataPath " + Application.dataPath);
    }

    public void Parse()
    {
        string json = Resources.Load("tickets").ToString();
        Debug.Log(json);
        _models = JsonUtility.FromJson<GameMetaDataModels>(json);
        Debug.Log(_models);
        for (int i = 0; i < _models.tickets.Length; i++)
        {
            randomIndexes.Add(i);
        }
           
    }
    public void MixIndexes()
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
    public TicketModel GetModel()
    {
        active_index++;
        if (active_index >= _models.tickets.Length)
            MixIndexes();
        Debug.Log("active index= " + active_index + " randomIndexes size = " + randomIndexes.Count);
        int value = randomIndexes[active_index];
        Debug.Log("value = " + value);
        TicketModel model = _models.tickets[value];
        return model;
    }

}
