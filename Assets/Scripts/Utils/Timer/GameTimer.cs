using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using System;

public class GameTimer : MonoBehaviour
{
    public List<TimeOutEvent> actions;
    public int timeout;
    private bool startCoroutine = false;
    [SerializeField] private TimerLeft timerLeft;

    public void NewGameFuelTimer()
    {
        startCoroutine = true;
        if (timerLeft == null)
            timerLeft = GetComponent<TimerLeft>();
        Debug.Log("Start timer " + timeout);
        timerLeft.ResetTimer();
        StartCoroutine(WaitCoroutine());
    }

    public void StopCoroutine()
    {
        startCoroutine = false;
    }
    IEnumerator WaitCoroutine()
    {
            yield return new WaitForSeconds(timeout);
            foreach (TimeOutEvent t in actions)
            {
                t.Invoke();
            }
            if(startCoroutine)
                StartCoroutine(WaitCoroutine());
          
    }
}
