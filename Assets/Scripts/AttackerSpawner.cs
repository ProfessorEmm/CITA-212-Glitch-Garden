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
        Attacker newAttacker = Instantiate
            (attackerPrefab, transform.position, transform.rotation) 
            as Attacker;
        // The parent of the instantiated Attacker is the transform.
        // This means that the Spawner object for each lane is the 
        // parent of the new Attacker. This will allow us to track 
        // the lanes where Attackers have been spawned.
        newAttacker.transform.parent = transform;
    } // SpawnAttacker()
    
} // class AttackerSpawner
