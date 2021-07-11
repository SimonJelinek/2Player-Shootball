using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        App.gameManager = this;
    }

    void Start()
    {
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
    }

    public void StartGame()
    {
        App.screenManager.Show<InGameScreen>();
        App.screenManager.Hide<MenuScreen>();
    }

    public void ReturnToMenu()
    {
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
    }
}
