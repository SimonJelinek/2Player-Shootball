using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform inGameHolder;
    public GameObject backGround;

    void Awake()
    {
        App.gameManager = this;
    }

    void Start()
    {
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        backGround.SetActive(false);
    }

    public void StartGame()
    {
        App.screenManager.Show<InGameScreen>();
        App.screenManager.Hide<MenuScreen>();
        backGround.SetActive(true);
    }

    public void ReturnToMenu()
    {
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        backGround.SetActive(false);
        foreach (Transform child in inGameHolder)
        {
            Destroy(child.gameObject);
        }
    }
}
