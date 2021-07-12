using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBulletBehavior : MonoBehaviour
{
    public Transform bluePlayer;
    public float speed;
    private Rigidbody2D rb;
    private Vector2 dir;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        dir.x = xDir();
        rb.velocity = new Vector2(dir.x,-1)*speed;
        Debug.Log(dir.x);
    }

    float xDir() 
    {
        return App.playerBlue.gameObject.transform.rotation.z;
    }
}
