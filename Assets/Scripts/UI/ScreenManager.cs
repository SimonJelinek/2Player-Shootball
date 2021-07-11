using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public ScreenBase[] screens;

    void Awake()
    {
        screens = GetComponentsInChildren<ScreenBase>(true);
        App.screenManager = this;
    }

    public virtual void Show<T>()
    {
        foreach (ScreenBase screen in screens)
        {
            if (screen.GetType()==typeof(T))
            {
                screen.Show();
            }
        }
    }

    public virtual void Hide<T>()
    {
        foreach (ScreenBase screen in screens)
        {
            if (screen.GetType() == typeof(T))
            {
                screen.Hide();
            }
        }
    }
}
