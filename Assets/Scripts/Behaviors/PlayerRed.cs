using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRed : PlayerBehavior
{
    public Transform gun;
    public GameObject bullet;
    public Vector2 bulletSpawnPos;

    public bool canshoot = true;

    void Awake()
    {
        App.playerRed = this;
    }

    public void Shoot()
    {
        if (App.gameManager.rotate) 
        {
        if (canshoot) 
        {
            bulletSpawnPos = gun.position;
            Instantiate(bullet, bulletSpawnPos, Quaternion.identity, App.parent); 
            App.lights.redRed.SetActive(true);
            App.lights.redGreen.SetActive(false);  
            canshoot = false;
            App.soundManager.PlaySound(0);
        }
        }
    }
}
