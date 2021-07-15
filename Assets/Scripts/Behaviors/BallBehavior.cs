using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    void Awake() 
    {
        App.ballBehavior = this;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Bullet") 
        {
            Destroy(collision.gameObject);
            App.soundManager.PlaySound(1);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "BlueLine") 
        {
            App.inGameScreen.RedScore();
            App.soundManager.PlaySound(2);
        }
        if (collider.gameObject.tag == "RedLine") 
        {
            App.inGameScreen.BlueScore();
            App.soundManager.PlaySound(2);
        }
    }
}
