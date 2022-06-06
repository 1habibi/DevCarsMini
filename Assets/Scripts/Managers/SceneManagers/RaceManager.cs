using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaceManager : GameScreen
{
    [SerializeField] GameCar gameCar = null;
    // [SerializeField] TestCarMovment carMovment;

    public override void OnShow()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "FirstLevel")
            gameCar.NewGame(15);
        else if (EventSystem.current.currentSelectedGameObject.name == "SecondLevel")
            gameCar.NewGame(20);
        else if (EventSystem.current.currentSelectedGameObject.name == "ThirdLevel")
            gameCar.NewGame(25);
        else if (EventSystem.current.currentSelectedGameObject.name == "FourthLevel")
            gameCar.NewGame(30);
        else if (EventSystem.current.currentSelectedGameObject.name == "FifthLevel")
            gameCar.NewGame(35);
    }
}
