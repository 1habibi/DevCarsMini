using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerLeft : MonoBehaviour
{
    [SerializeField] private int TimeLeft;
    [SerializeField] private TextMeshProUGUI textMesh;
    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = TimeLeft.ToString();
    }
    public void Tick()
    {
        TimeLeft--;
        if (TimeLeft <= 0)
        {
            Debug.Log("Game Over");
        }
        textMesh.text = TimeLeft.ToString();    
    }

    public void DamageTick()
    {
        TimeLeft = TimeLeft - 10;
        if (TimeLeft <= 0)
        {
            Debug.Log("Game Over");
        }
        textMesh.text = TimeLeft.ToString();
    }
}
