using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceLoseManager : GameScreen
{
    public override void OnShow()
    {

    }
    public void OpenMenu()
    {
        MainSceneManager.Instance.SwapScene(SceneType.RACELOSE, SceneType.SELECTLEVEL);
        AudioManager.Instance.PlaySoundtrack();
    }
}
