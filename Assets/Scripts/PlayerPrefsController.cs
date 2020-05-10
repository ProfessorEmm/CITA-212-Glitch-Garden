using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";
    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;
    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;

    public static void SetMasterVolume(float fltVolume)
    {
        if (fltVolume >= MIN_VOLUME && fltVolume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, fltVolume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    } // SetMasterVolume

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    } // GetMasterVolume()

    public static void SetDifficulty(float fltDifficulty)
    {
        if (fltDifficulty >= MIN_DIFFICULTY && fltDifficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, fltDifficulty);
        }
        else
        {
            Debug.LogError("Difficulty setting is not in range");
        }
    } // SetDifficulty()

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    
    } // GetDifficulty()

} // class PlayaerPrefsController
