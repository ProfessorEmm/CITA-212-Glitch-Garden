﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LabelButtonWithCost();
    } // Start

    private void LabelButtonWithCost()
    {
        Text txtCost = GetComponentInChildren<Text>();
        if (!txtCost)
        {
            Debug.LogError(name + " has no cost text, add some");
        }
        else
        {
            txtCost.text = defenderPrefab.GetStarCost().ToString();
        }
    } // LabelButtonWithCost()

    private void OnMouseDown()
    {
        // create a temporary variable to store our DefenderButtons
        var buttons = FindObjectsOfType<DefenderButton>();
        // Iterate through the collection of DefenderButtons
        foreach (DefenderButton button in buttons)
        {
            // Change the color of a button in the collection
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        // change the color of the defenders in the background
        GetComponent<SpriteRenderer>().color = Color.white;
        // when called, we will know what to pass in when a defender is spawned
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);

    } // OnMouseDown

} // class DefenderButton
