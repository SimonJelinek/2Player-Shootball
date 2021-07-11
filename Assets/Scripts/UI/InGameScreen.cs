using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScreen : ScreenBase
{
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
} 
