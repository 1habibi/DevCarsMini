using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCar : MonoBehaviour
{
    [SerializeField] GameObject parent;
    [SerializeField] GameObject prefab;
    [SerializeField] private int countObjects;
    [SerializeField] CarSkinManager carSkinManager;
    [SerializeField] GameTimer gameTimer;
    [SerializeField] TestCarMovment carMovment;
    [SerializeField] FinishModel finishModel;
    [SerializeField] List<BonusModel> bonusModels; 
    private bool isBackInit = false;
    public void NewGame(int dmg)
    {
        Debug.Log(isBackInit);
        carMovment.damage = dmg;
        carSkinManager.Initialization();
        carSkinManager.SetSkin();
        carMovment.InitCarMovment();
        finishModel.NewGameFinishCoroutine();
        gameTimer.NewGameFuelTimer();
        foreach(BonusModel bonus in bonusModels)
        {
            bonus.DefaultPosition();
        }
        if(isBackInit == false)
        {
            for (int i = 0; i < countObjects; i++)
            {
                GameObject newObject = Instantiate(prefab, new Vector3(Random.Range(-9, 9), Random.Range(-5.5f, 6f), 0), Quaternion.identity);
                newObject.transform.parent = parent.transform;
            }
            isBackInit = true;
        }
       
    }  
}
