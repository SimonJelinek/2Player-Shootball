using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource[] sounds; 

    void Awake() 
    {
        App.soundManager = this;
    }

    public void PlaySound(int i) 
    {
        sounds[i].volume = PlayerPrefs.GetFloat("volume"); 
        sounds[i].Play();
    }
}

