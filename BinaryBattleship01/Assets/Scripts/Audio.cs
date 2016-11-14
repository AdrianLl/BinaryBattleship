using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

 

   private AudioSource backgroundMusic;

	// Use this for initialization
	void Start () {
        backgroundMusic = GetComponent<AudioSource>();

    }

    public void MuteAudio()
    {
        if(backgroundMusic!= null){
            if (backgroundMusic.mute == true)
                backgroundMusic.mute = false;
            else
                backgroundMusic.mute = true;
        }
  
    }
}