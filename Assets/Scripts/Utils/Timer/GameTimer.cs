using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using System;

public class GameTimer : MonoBehaviour
{
    public List<TimeOutEvent> actions;
    public int timeout;
    void Awake()
    {
        Debug.Log("Start timer " + timeout);
        StartCoroutine(WaitCoroutine());
    }
    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(timeout);
        foreach(TimeOutEvent t in actions){
            t.Invoke();
        }
        StartCoroutine(WaitCoroutine());
    }
}
