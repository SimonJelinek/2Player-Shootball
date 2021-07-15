using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject lines;

    public bool rotate = true;
    public float t;

    void Awake()
    {
        App.gameManager = this;
        App.parent = inGameHolder;
    }

    void Start()
    {
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        App.screenManager.Hide<GameOverScreen>();
        backGround.SetActive(false);
    }

    public void StartGame(float timee)
    {
        App.screenManager.Show<InGameScreen>();
        App.screenManager.Hide<MenuScreen>();
        App.screenManager.Hide<GameOverScreen>();
        App.screenManager.Hide<LevelsScreen>();
        InstantiateMap();
        App.inGameScreen.time = timee;
        App.lights.StartGame();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame() 
    {
        App.screenManager.Hide<GameOverScreen>();
        App.inGameScreen.time = 60;
        App.inGameScreen.count = true;
        App.inGameScreen.redScore = 0;
        App.inGameScreen.blueScore = 0;
        App.inGameScreen.ReloadTxt();
        StartGame(t);
    }

    public void GoalRed() 
    {
        rotate = false;
        SetStartRot();
        StartCoroutine(ScoreGoalRed());
    }

    public void GoalBlue() 
    {
        rotate = false;
        SetStartRot();
        StartCoroutine(ScoreGoalBlue());
    }

    IEnumerator ScoreGoalRed() 
    {
        App.ballBehavior.gameObject.SetActive(false);
        yield return new WaitForSeconds(3);
        App.ballBehavior.gameObject.transform.position = new Vector3();
        App.ballBehavior.gameObject.SetActive(true);
        App.inGameScreen.redGoalTxt.text = "";
        rotate = true;
        App.playerRed.canshoot = true;
        App.playerBlue.canshoot = true;
        App.lights.redGreen.SetActive(true);
        App.lights.blueGreen.SetActive(true);
        App.lights.redRed.SetActive(false);
        App.lights.blueRed.SetActive(false);
    }

    IEnumerator ScoreGoalBlue() 
    {
        App.ballBehavior.gameObject.SetActive(false);
        yield return new WaitForSeconds(3);
        App.ballBehavior.gameObject.transform.position = new Vector3();
        App.ballBehavior.gameObject.SetActive(true);
        App.inGameScreen.blueGoalTxt.text = "";
        rotate = true;
        App.playerRed.canshoot = true;
        App.playerBlue.canshoot = true;
        App.lights.redGreen.SetActive(true);
        App.lights.blueGreen.SetActive(true);
        App.lights.redRed.SetActive(false);
        App.lights.blueRed.SetActive(false);
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
        Instantiate(lines, new Vector2(), Quaternion.identity, inGameHolder);
    }

    void SetStartRot() 
    {
        App.playerRed.gameObject.transform.rotation = Quaternion.Euler(0,0,90);
        App.playerBlue.gameObject.transform.rotation = Quaternion.Euler(0,0,90);
        App.playerRed.canshoot = false;
        App.playerBlue.canshoot = false;
        App.lights.redGreen.SetActive(false);
        App.lights.blueGreen.SetActive(false);
        App.lights.redRed.SetActive(true);
        App.lights.blueRed.SetActive(true);
    }
}
