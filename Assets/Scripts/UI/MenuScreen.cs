using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void ShowSettings() 
    {
        App.screenManager.Show<SettingsScreen>();
        App.screenManager.Hide<MenuScreen>();
    }
    
    public void ShowLevels() 
    {
        App.screenManager.Show<LevelsScreen>();
        App.screenManager.Hide<MenuScreen>();
    }

    public void HideLevels() 
    {
        App.screenManager.Hide<LevelsScreen>();
        App.screenManager.Show<MenuScreen>();
    }

    public void QuitButton() 
    {
        Application.Quit();
    }
}
