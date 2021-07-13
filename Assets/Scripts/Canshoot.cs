using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canshoot : MonoBehaviour
{
    void Awake() 
    {
        App.canshoot = this;
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Shoot") 
        {
            if (gameObject.transform.position.y > 0) 
            {
                if (!App.playerBlue.canshoot) 
                {
                    App.lights.blueGreen.SetActive(true);
                    App.playerBlue.canshoot = true;
                }
            }
            else 
            {
                //Red
                if (!App.playerRed.canshoot) 
                {
                    App.lights.redGreen.SetActive(true);
                    App.playerRed.canshoot = true;
                }
            }
        }
    }
}
