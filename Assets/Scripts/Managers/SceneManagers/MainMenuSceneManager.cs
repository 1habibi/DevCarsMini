using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenuSceneManager : GameScreen
{
    [SerializeField] QuizPlayManager _quizPlayManager;
    [SerializeField] GameCar _gameCar;
    // [SerializeField] AudioManager audioManager;

    public override void OnShow()
    {

    }

    private void Start()
    {
        AudioManager.Instance.PlaySoundtrack();
    }
    public void Exit()
    {
        AudioManager.Instance.TapUIButtons();
        Application.Quit();
    }
    public void ShowSelectLevel()
    {
        MainSceneManager.Instance.SwapScene(SceneType.GAMEMENU, SceneType.SELECTLEVEL);
        AudioManager.Instance.TapUIButtons();
        // User.skin = 0;
        Debug.Log(User.skin);
    }
    public void ShowStore()
    {
        MainSceneManager.Instance.SwapScene(SceneType.GAMEMENU, SceneType.STORE);
        AudioManager.Instance.TapUIButtons();
    }
    public void BackMenuFromSelectLevel()
    {
        MainSceneManager.Instance.SwapScene(SceneType.SELECTLEVEL, SceneType.GAMEMENU);
        AudioManager.Instance.TapUIButtons();
    }
    public void BackMenuFromStore()
    {
        MainSceneManager.Instance.SwapScene(SceneType.STORE, SceneType.GAMEMENU);
        AudioManager.Instance.TapUIButtons();
    }
    public void ShowQuizPlay()
    {
        MainSceneManager.Instance.SwapScene(SceneType.SELECTLEVEL, SceneType.QUIZPLAY);
        AudioManager.Instance.TapUIButtons();
        AudioManager.Instance.StopSoundtrack();
    }
    public void ShowRacePlay()
    {
        MainSceneManager.Instance.SwapScene(SceneType.SELECTLEVEL, SceneType.RACEPLAY);
        AudioManager.Instance.TapUIButtons();
        AudioManager.Instance.PlayRaceMusic();
    }

}
