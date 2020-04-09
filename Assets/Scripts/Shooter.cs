using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    public void Fire()
    {
        // create a projectile and move it based on the position of the gun 
        Instantiate(projectile, gun.transform.position, transform.rotation);
    } // Fire()
} // class Shooter()
