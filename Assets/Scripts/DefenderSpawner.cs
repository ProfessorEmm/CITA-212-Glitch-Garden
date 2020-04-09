using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        // spawn the defender
        SpawnDefender();

    } // OnMouseDown()

    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity) as GameObject;
    }

} // class DefenderSapwner
