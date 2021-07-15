using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : ScreenBase
{
    public TMP_Text redScoreTxt;
    public TMP_Text blueScoreTxt;

    void Awake() 
    {
        App.gameOverScreen = this;
    }

    public void GameOver() 
    {
        redScoreTxt.text = App.inGameScreen.redScore.ToString();
        blueScoreTxt.text = App.inGameScreen.blueScore.ToString();
        foreach (Transform c in App.gameManager.inGameHolder) 
        {
            Destroy(c.gameObject);
        }
    }

    public void ReturnToMenu() 
    {
        App.gameManager.ReturnToMenu();
    }
}
