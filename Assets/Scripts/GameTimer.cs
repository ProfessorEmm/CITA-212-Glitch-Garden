using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    // add a tooltip to our level timer
    [Tooltip("Level Timer in SECONDS")]
    [SerializeField] float fltLevelTime = 10;   

    
    void Update()
    {
        // track time on our slider
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;

        bool boolTimerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        if (boolTimerFinished)
        {
            Debug.Log("level timer expired.");
        }
    }
} // class GameTimer
