using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canshoot : MonoBehaviour
{
    public GameObject redGreen;
    public GameObject redRed;
    public GameObject blueGreen;
    public GameObject blueRed;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Shoot") 
        {
            //Pridat svetielka a podmienku na strielanie
        }
    }
}
