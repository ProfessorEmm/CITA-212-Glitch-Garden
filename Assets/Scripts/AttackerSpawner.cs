using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float fltMinSpawnDelay = 2f;
    [SerializeField] float fltMaxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        { 
            // delay before spawning
            yield return new WaitForSeconds(UnityEngine.Random.Range(fltMinSpawnDelay, fltMaxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
