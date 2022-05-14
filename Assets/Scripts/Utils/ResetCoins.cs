using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCoins : MonoBehaviour
{
    public void Reset()
    {
        Menu.Instance.totalReward = 0;
        Menu.Instance.SaveGame();
        
    }
}
