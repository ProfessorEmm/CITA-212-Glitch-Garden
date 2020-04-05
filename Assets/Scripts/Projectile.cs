using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float fltSpeed = 1f;
    [SerializeField] float fltDamage = 50f;
    
    void Update()
    {
        transform.Translate(Vector2.right * fltSpeed * Time.deltaTime);
    } // Update()

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        health.DealDamage(fltDamage);
    }
}
