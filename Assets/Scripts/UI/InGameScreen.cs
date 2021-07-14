using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameScreen : ScreenBase
{
    public TMP_Text blueGoalTxt;
    public TMP_Text redGoalTxt;
    public TMP_Text redScoreText;
    public TMP_Text blueScoreText;

    int redScore = 0;
    int blueScore = 0;

    void Awake() 
    {
        App.inGameScreen = this;
    }

    public void ReturnToMenu()
    {
        App.gameManager.ReturnToMenu();
    }

    public void RedShoot()
    {
        App.playerRed.Shoot();
    }

    public void BlueShoot()
    {
        App.playerBlue.Shoot();
    }

    public void BlueScore() 
    {
        blueScore++;
        blueScoreText.text = blueScore.ToString();
        blueGoalTxt.text = "Goal!";
        App.gameManager.GoalBlue();
    }

    public void RedScore() 
    {
        redScore++;
        redScoreText.text = redScore.ToString();
        redGoalTxt.text = "Goal!";
        App.gameManager.GoalRed();
    }
} 
