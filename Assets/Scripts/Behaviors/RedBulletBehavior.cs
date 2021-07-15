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
        dir.y = yDir();
        rb.velocity = new Vector2(dir.x, dir.y)*speed;
    }


    void FixedUpdate() 
    {
        transform.Rotate(new Vector3(0,0,1));
    }

    float xDir() 
    {
        //return Mathf.Abs(App.playerRed.gameObject.transform.rotation.z);
        return App.playerRed.gameObject.transform.rotation.z;
    }

    int yDir() 
    {
        if (dir.x < -0.7f || dir.x > 0.7f) 
        {
            return -1;
        }
        else 
        {
            return 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Void" || collision.gameObject.tag == "PlayerBlue" || collision.gameObject.tag == "Bullet") 
        {
            Destroy(gameObject);
        }
    }
}
