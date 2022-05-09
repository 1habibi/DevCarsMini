using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject storeMenu;
    [SerializeField] private GameObject levelsMenu;
    [SerializeField] private GameObject earnCoins;

    void Awake()
    {
        mainMenu.SetActive(true);
        storeMenu.SetActive(false);
        levelsMenu.SetActive(false);
        earnCoins.SetActive(false);
    }
    public void pushStore()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(true);
        levelsMenu.SetActive(false);
        earnCoins.SetActive(false);
    }
    public void pushBacktoMenu()
    {
        mainMenu.SetActive(true);
        storeMenu.SetActive(false);
        levelsMenu.SetActive(false);
        earnCoins.SetActive(false);
    }
    public void pushPlay()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(false);
        levelsMenu.SetActive(true);
        earnCoins.SetActive(false);
    }
    public void pushEarnCoins()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(false);
        levelsMenu.SetActive(false);
        earnCoins.SetActive(true);
    }

}
