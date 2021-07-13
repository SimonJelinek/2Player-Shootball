using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRed : PlayerBehavior
{
    public Transform gun;
    public GameObject bullet;
    public Vector2 bulletSpawnPos;

    void Awake()
    {
        App.playerRed = this;
    }

    public void Shoot()
    {
        //f (Canshoot.blueGreen.gameObject.active) 
        //{
        bulletSpawnPos = gun.position;
        Instantiate(bullet, bulletSpawnPos, Quaternion.identity, App.parent);   
        //}
    }
}
