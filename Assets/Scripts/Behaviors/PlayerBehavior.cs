using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float rotSpeed;

    void Awake()
    {
        App.playerBehavior = this;
    }

    void FixedUpdate()
    {
        if (App.gameManager.rotate) 
        {
            transform.Rotate(new Vector3(0,0,-1*rotSpeed));
        }        
    }
}
