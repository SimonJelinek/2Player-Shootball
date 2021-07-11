using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBulletBehavior : MonoBehaviour
{
    public Transform redGun;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 dir;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        dir = redGun.position;
        dir.y += 0.2f;
        rb.velocity = (dir)*speed;
    }
}
