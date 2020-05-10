using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float fltDefaultVolume = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    } // Start()

    // Update is called once per frame
    void Update()
    {
        // create a MusicPlayer
        var musicPlayer = FindObjectOfType<MusicPlayer>();

        if (musicPlayer)
        {
            // last set value
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found...did you start from Splash screen?");
        }
    } // Update()

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();

    } // SaveAndExit()

    public void SetDefaults()
    {
        volumeSlider.value = fltDefaultVolume;

    } // SetDefaults()


} // class OptionsController
