using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform inGameHolder;
    public GameObject backGround;
    public GameObject playerRed;
    public GameObject playerBlue;

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
        InstantiateMap();
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

    void InstantiateMap()
    {
        backGround.SetActive(true);
        Instantiate(playerRed, new Vector2(-0.046f, -3.43f), Quaternion.identity, inGameHolder);
        Instantiate(playerBlue, new Vector2(-0.046f, 3.48f), Quaternion.identity, inGameHolder);
    }
}
