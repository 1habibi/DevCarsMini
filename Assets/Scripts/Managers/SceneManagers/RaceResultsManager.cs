using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceResultsManager : GameScreen
{
    [SerializeField] TestCarMovment game;
    [SerializeField] private Text resultText;
    public override void OnShow()
    {
        if (game == null)
            game = GetComponent<TestCarMovment>();
        resultText.text = game.raceReward.ToString();
    }
    public void OpenMenu()
    {
        MainSceneManager.Instance.SwapScene(SceneType.RACERESULTS, SceneType.SELECTLEVEL);
        AudioManager.Instance.PlaySoundtrack();
    }

}
