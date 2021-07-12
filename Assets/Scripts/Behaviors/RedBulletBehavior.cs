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
        dir.x = xDir();
        rb.velocity = new Vector2(dir.x,1)*speed;
        Debug.Log(dir.x);
    }


    void FixedUpdate() 
    {
        transform.Rotate(new Vector3(0,0,1));
    }

    float xDir() 
    {
        return App.playerRed.gameObject.transform.rotation.z;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Void") 
        {
            Destroy(gameObject);
        }
    }
}
