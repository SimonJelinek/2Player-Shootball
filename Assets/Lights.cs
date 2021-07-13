using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject redGreen;
    public GameObject redRed;
    public GameObject blueGreen;
    public GameObject blueRed;

    void Awake() 
    {
        App.lights = this;
    }

    void Start()
    {
        ReturnToMenu();
    }

    public void StartGame() 
    {
        redGreen.SetActive(true);
        blueGreen.SetActive(true);
        redRed.SetActive(false);
        blueRed.SetActive(false);
    }

    public void ReturnToMenu() 
    {
        redGreen.SetActive(false);
        blueGreen.SetActive(false);
        redRed.SetActive(false);
        blueRed.SetActive(false);
    }
}
