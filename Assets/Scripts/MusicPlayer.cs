using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        // change the volume
        audioSource.volume = PlayerPrefsController.GetMasterVolume();

    } // Start()

    public void SetVolume(float fltVolume)
    {
        audioSource.volume = fltVolume;
    } // SetVolume()

} // class MusicPlayer
