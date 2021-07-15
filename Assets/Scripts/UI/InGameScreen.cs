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
    public TMP_Text redTimeTxt;
    public TMP_Text blueTimeTxt;

    public float time;
    float minute;
    public int redScore = 0;
    public int blueScore = 0;

    bool count = true;

    void Awake() 
    {
        App.inGameScreen = this;
    }

    void Update() 
    {
        if (gameObject.active && App.gameManager.rotate && count) 
        {
            time -= Time.deltaTime;
            minute -= Time.deltaTime;
            CheckTime();
            if (minute >= 10) 
            {
               redTimeTxt.text  = ((int)(time/60)).ToString() + ":" + (int)minute; 
               blueTimeTxt.text = ((int)(time/60)).ToString() + ":" + (int)minute; 
            }
            else 
            {
               redTimeTxt.text  = ((int)(time/60)).ToString() + ":0" + (int)minute; 
               blueTimeTxt.text = ((int)(time/60)).ToString() + ":0" + (int)minute; 
            }
        }
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

    void CheckTime() 
    {
        if (minute<=0) 
        {
            minute = 60;
        }
        if (time <= 0) 
        {
            count = false;
            GameOver();
        }
    }

    void GameOver() 
    {
        App.screenManager.Show<GameOverScreen>();
        App.gameOverScreen.GameOver();
    }
} 
