using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBulletBehavior : MonoBehaviour
{
    public Transform blueGun;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 dir;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        dir = blueGun.position;
        dir.y += 0.2f;
        rb.velocity = (dir) * speed;
    }
}
