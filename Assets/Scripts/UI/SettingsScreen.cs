using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : ScreenBase
{
    public Slider volume;

    void Awake() 
    {
        App.settingsScreen = this;
    }

    public void ReturnToMenu() 
    {
        Hide();
        App.screenManager.Show<MenuScreen>();
        PlayerPrefs.SetFloat("volume", volume.value);
        App.soundManager.PlaySound(3);
    }
}
