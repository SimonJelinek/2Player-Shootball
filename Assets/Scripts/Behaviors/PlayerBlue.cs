using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : PlayerBehavior
{
    public Transform gun;
    public GameObject bullet;
    public Vector2 bulletSpawnPos;

    public bool canshoot = true;

    void Awake()
    {
        App.playerBlue = this;
    }

    public void Shoot()
    {
        if (App.gameManager.rotate) {
             if (canshoot) 
        {
            bulletSpawnPos = gun.position;
            Instantiate(bullet, bulletSpawnPos, Quaternion.identity, App.parent); 
            App.lights.blueRed.SetActive(true);
            App.lights.blueGreen.SetActive(false);  
            canshoot = false;
        }
        }
    }
}
