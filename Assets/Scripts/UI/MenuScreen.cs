using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void ShowSettings() 
    {
        App.screenManager.Show<SettingsScreen>();
        App.screenManager.Hide<MenuScreen>();
        App.settingsScreen.volume.value = PlayerPrefs.GetFloat("volume");
        App.soundManager.PlaySound(3);
    }
    
    public void ShowLevels() 
    {
        App.screenManager.Show<LevelsScreen>();
        App.screenManager.Hide<MenuScreen>();
        App.soundManager.PlaySound(3);
    }

    public void HideLevels() 
    {
        App.screenManager.Hide<LevelsScreen>();
        App.screenManager.Show<MenuScreen>();
        App.soundManager.PlaySound(3);
    }

    public void QuitButton() 
    {
        Application.Quit();
    }
}
