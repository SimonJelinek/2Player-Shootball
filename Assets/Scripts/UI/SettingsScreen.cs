using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScreen : ScreenBase
{
    public void ReturnToMenu() 
    {
        Hide();
        App.screenManager.Show<MenuScreen>();
    }
}
