using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCar : Singleton<GameCar>
{

    [SerializeField] GameObject parent;
    [SerializeField] GameObject prefab;
    [SerializeField] private int countObjects = 2;
    [Range(0, 100)]
    [SerializeField] private int minXSpawn = -9;
    [Range(0, 100)]
    [SerializeField] private int minYSpawn = 9;

    override public void Awake()
    {
        base.Awake();
        NewGame();
    }
    public void NewGame()
    {
        for (int i = 0; i < countObjects; i++)
        {
            GameObject newObject = Instantiate(prefab, new Vector3(Random.Range(-9,9), Random.Range(-5.5f, 6f), 0), Quaternion.identity);
            newObject.transform.parent = parent.transform;
        }
    }  
}
