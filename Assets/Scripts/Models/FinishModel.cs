using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishModel : MonoBehaviour
{
    [SerializeField] private bool canRun;
    [SerializeField] private Vector3 increaseValues;

   public void NewGameFinishCoroutine()
   {
        canRun = false;
        transform.position = new Vector3(-2, 7, -2);
        StartCoroutine(FinishCoroutine(10));
   }

   void Update()
   {
        if (canRun)
        {
            transform.localPosition += increaseValues * Time.deltaTime;
        }
   }
    IEnumerator FinishCoroutine(int delay)
    {
        Debug.Log("delay= " + delay);
        yield return new WaitForSeconds(delay);
        canRun = true;
    }
}
