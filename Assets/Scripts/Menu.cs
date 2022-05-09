using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject storeMenu;
    [SerializeField] private GameObject levelsMenu;

    public void pushStore()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(true);
        levelsMenu.SetActive(false);
    }
    public void pushBacktoMenu()
    {
        storeMenu.SetActive(false);
        levelsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void pushPlay()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(false);
        levelsMenu.SetActive(true);
    }

}
