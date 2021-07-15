using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    
    public void ShowLevels() 
    {
        App.screenManager.Show<LevelsScreen>();
    }

    public void HideLevels() 
    {
        App.screenManager.Hide<LevelsScreen>();
    }

    public void QuitButton() 
    {
        Application.Quit();
    }
}
