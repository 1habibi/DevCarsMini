using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
   private Menu _menu;

   public enum State { MENU, STORE, LEVELS, EARNCOINS }

   public void SetState(State value)
   {
        switch (value)
        {
            case State.MENU:
                    _menu.mainMenu.SetActive(true);
                    _menu.storeMenu.SetActive(false);
                    _menu.levelsMenu.SetActive(false);
                    _menu.earnCoins.SetActive(false);
                break;         
            case State.STORE:
                _menu.mainMenu.SetActive(false);
                _menu.storeMenu.SetActive(true);
                _menu.levelsMenu.SetActive(false);
                _menu.earnCoins.SetActive(false);
                break;
            case State.LEVELS:
                _menu.mainMenu.SetActive(false);
                _menu.storeMenu.SetActive(false);
                _menu.levelsMenu.SetActive(true);
                _menu.earnCoins.SetActive(false);
                break;
            case State.EARNCOINS:
                _menu.mainMenu.SetActive(false);
                _menu.storeMenu.SetActive(false);
                _menu.levelsMenu.SetActive(false);
                _menu.earnCoins.SetActive(true);
                break;
        }
   }
}
