using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float fltDefaultVolume = 0.8f;

    [SerializeField] Slider difficultySlider;
    [SerializeField] float fltDefaultDifficulty = 0f;

    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();

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
        PlayerPrefsController.SetDifficulty(difficultySlider.value);

        FindObjectOfType<LevelLoader>().LoadMainMenu();

    } // SaveAndExit()

    public void SetDefaults()
    {
        volumeSlider.value = fltDefaultVolume;
        difficultySlider.value = fltDefaultDifficulty;

    } // SetDefaults()

} // class OptionsController
