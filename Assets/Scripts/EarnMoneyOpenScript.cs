using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EarnMoneyOpenScript : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }
}
