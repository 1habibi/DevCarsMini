using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizPlayManager : GameScreen
{
    [SerializeField] Game _game = null;
    public override void OnShow()
    {
        if (_game == null)
            _game = GetComponent<Game>();
        _game.NewGame();  
    }
}
