using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float fltHealth = 100f; // health of attacker
    [SerializeField] GameObject deathVFX; // particle effects for death of an attacker

    public void DealDamage(float fltDamage)
    {
        fltHealth -= fltDamage; // increase damage to attacker
        if (fltHealth <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject); // attacker
        } // if
    } // DealDamage()

    private void TriggerDeathVFX()
    {
        if (!deathVFX)
        {
            return;
        } // if
        // create a particle effect when an attacker dies
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f); // destroy particle effect
    } // TriggerDeathVFX()

} // class Health
