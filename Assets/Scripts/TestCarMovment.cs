using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCarMovment : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject timerLeft;
    [SerializeField] private GameTimer gameTimer;
    [SerializeField] public int raceReward;
    [SerializeField] public int damage;



    public void InitCarMovment()
    {
        if (rb2D == null)
            rb2D = gameObject.GetComponent<Rigidbody2D>();
        raceReward = 0;
        GetComponent<Transform>().position = new Vector3(-1, -4, -7);
    }

    void Update()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        rb2D.MovePosition(transform.position + m_Input * Time.deltaTime * moveSpeed);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.GetComponent<BonusModel>() != null)
        {
            BonusModel bonusModel = obj.GetComponent<BonusModel>(); 
            Debug.Log("Bonus =" + bonusModel.BonusDamage());
            if (bonusModel.BonusDamage() == -1)
            {
                timerLeft.GetComponent<TimerLeft>().DamageTick(damage);
                AudioManager.Instance.TakeDamage();
            }
            if(bonusModel.BonusDamage() == 1)
            {
                raceReward += 1;
                AudioManager.Instance.TakeCoin();
            }
            if(bonusModel.isActiveAndEnabled)
            {
                bonusModel.RestartPosition(Random.Range(3, 5));
            }
        }
        else if(obj.GetComponent<FinishModel>() != null)
        {
            TotalReward.Instance.SetReward(raceReward);
            gameTimer.StopCoroutine();
            AudioManager.Instance.StopRaceMusic();
            MainSceneManager.Instance.SwapScene(SceneType.RACEPLAY, SceneType.RACERESULTS);
            AudioManager.Instance.WinRace();
        }
    }
}
