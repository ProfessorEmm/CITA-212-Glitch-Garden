using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float fltHealth = 100f;

    public void DealDamage(float fltDamage)
    {
        fltHealth -= fltDamage;
        if (fltHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    
} // class Health
