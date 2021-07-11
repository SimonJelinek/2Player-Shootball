using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : PlayerBehavior
{
    public Transform gun;
    public GameObject bullet;
    public Vector2 bulletSpawnPos;

    void Awake()
    {
        App.playerBlue = this;
    }

    public void Shoot()
    {
        bulletSpawnPos = gun.position;
        Instantiate(bullet, bulletSpawnPos, Quaternion.identity, App.parent);
    }
}
