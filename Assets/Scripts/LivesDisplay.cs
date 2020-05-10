using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float fltBaseLives = 3f;
    [SerializeField] int intDamage = 1;
    float fltLives;
    Text txtLives;

    void Start()
    {
        fltLives = fltBaseLives - PlayerPrefsController.GetDifficulty();
        // to access the text component within the text field
        txtLives = GetComponent<Text>();
        UpdateDisplay();
        // teting to ensure that lives works correctly
        Debug.Log("Difficulty setting currently is: " + PlayerPrefsController.GetDifficulty());

    } // Start()

    private void UpdateDisplay()
    {
        // convert the integer star field to a string
        txtLives.text = fltLives.ToString();

    } // UpdateDisplay()

    public void TakeLife()
    {
        // decrease our lives by one
        fltLives -= intDamage;
        UpdateDisplay();
        if (fltLives <= 0)
        {
            // no lives remaining, go to LoseScreen
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }

    } // SpendStars()

} // class Lives
