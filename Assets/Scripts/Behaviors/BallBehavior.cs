using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "BlueLine") 
        {
            App.inGameScreen.RedScore();
        }
        if (collider.gameObject.tag == "RedLine") 
        {
            App.inGameScreen.BlueScore();
        }
    }
}
