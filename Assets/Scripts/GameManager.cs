using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform inGameHolder;
    public GameObject backGround;
    public GameObject playerRed;
    public GameObject playerBlue;
    public GameObject voidd;
    public GameObject ball;
    public GameObject shootBlue;
    public GameObject shootRed;

    void Awake()
    {
        App.gameManager = this;
        App.parent = inGameHolder;
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
        Instantiate(voidd, new Vector2(), Quaternion.identity, inGameHolder);
        Instantiate(ball, new Vector2(), Quaternion.identity, inGameHolder);
        Instantiate(shootBlue, new Vector2(-0.021f, 4.105f), Quaternion.identity, inGameHolder);
        Instantiate(shootRed, new Vector2(-0.03758601f, -3.949393f), Quaternion.identity, inGameHolder);
    }
}
