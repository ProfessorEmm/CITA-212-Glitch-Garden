using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float fltMinSpawnDelay = 2f;
    [SerializeField] float fltMaxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    bool boolSpawn = true; 

    IEnumerator Start()
    {
        while (boolSpawn)
        { 
            // delay before spawning
            yield return new WaitForSeconds(UnityEngine.Random.Range(fltMinSpawnDelay, fltMaxSpawnDelay));
            SpawnAttacker();
        } // while
    } // Start()

    private void SpawnAttacker()
    {
        // instantiate an attacker, randomly between min and max spawn delay
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    } // SpawnAttacker()

    
} // class AttackerSpawner
