using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerLeft : MonoBehaviour
{
    [SerializeField] private int TimeLeft;
    [SerializeField] private TextMeshProUGUI textMesh;
    [SerializeField] private GameTimer gameTimer;
    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void ResetTimer()
    {
        if (User.buySkin == "")
            TimeLeft = 15;
        else
            TimeLeft = User.fuel;
        Debug.Log(User.fuel);
        textMesh.text = TimeLeft.ToString();
    }
    public void Tick()
    {
        TimeLeft--;
        if (TimeLeft <= 0)
        {
            MainSceneManager.Instance.SwapScene(SceneType.RACEPLAY, SceneType.RACELOSE);
            gameTimer.StopCoroutine();
            AudioManager.Instance.LoseRace();
        }
        textMesh.text = TimeLeft.ToString();    
    }

    public void DamageTick(int value)
    {
        TimeLeft = TimeLeft - value;
        if (TimeLeft <= 0)
        {
            MainSceneManager.Instance.SwapScene(SceneType.RACEPLAY, SceneType.RACELOSE);
            gameTimer.StopCoroutine();
            AudioManager.Instance.LoseRace();
        }
        textMesh.text = TimeLeft.ToString();
    }
}
