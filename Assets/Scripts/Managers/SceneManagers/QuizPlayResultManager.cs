using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizPlayResultManager : GameScreen
{
    [SerializeField] Game game;
    [SerializeField] private Text resultText;
    public override void OnShow()
    {
        if (game == null)
            game = GetComponent<Game>();
        resultText.text = game.gameReward.ToString();
    }
    public void OpenMenu()
    {
        MainSceneManager.Instance.SwapScene(SceneType.QUIZPLAYRESULTS, SceneType.GAMEMENU);
        AudioManager.Instance.TapUIButtons();
        AudioManager.Instance.PlaySoundtrack();
    }
}
