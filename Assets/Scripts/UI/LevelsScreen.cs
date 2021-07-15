using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsScreen : ScreenBase
{
    public void StartGameFreePlay()
    {
        App.gameManager.StartGame(0);
        App.gameManager.t = 0;
        App.inGameScreen.count = false;
        App.inGameScreen.redTimeTxt.text = "0:00";      
        App.inGameScreen.blueTimeTxt.text = "0:00";
    }

    public void StartGameOne()
    {
        App.gameManager.StartGame(60);
        App.gameManager.t = 60;
        App.inGameScreen.count = true;
    }

    public void StartGameTwo()
    {
        App.gameManager.StartGame(120);
        App.gameManager.t = 120;
        App.inGameScreen.count = true;
    }

    public void StartGameThree()
    {
        App.gameManager.StartGame(180);
        App.gameManager.t = 180;
        App.inGameScreen.count = true;
    }
}
