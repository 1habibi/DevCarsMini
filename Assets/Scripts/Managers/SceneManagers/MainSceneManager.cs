using System.Collections.Generic;
using UnityEngine;

public enum SceneType {
    GAMEMENU = 0,
    SELECTLEVEL = 1,
    STORE = 2,
    QUIZPLAY = 3,
    RACEPLAY = 4,
    QUIZPLAYRESULTS = 5,
    RACERESULTS = 6,
    RACELOSE = 7,
}

public class MainSceneManager : Singleton<MainSceneManager>
{
    [SerializeField] private List<GameScreen> screens;

    public override void Awake()
    {
        base.Awake();
        _execute(null, screens[(int)SceneType.GAMEMENU]);
    }

    public void SwapScene(SceneType src , SceneType dest)
    {
            _execute(screens[(int)src], screens[(int)dest]);
    }

    private void _execute(GameScreen src, GameScreen dest) 
    {
            if (src != null){
                src.gameObject.SetActive(false);
            }
           dest.gameObject.SetActive(true);
           dest.OnShow();
            
    }
        
}
