using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float fltSpeed = 1f;
    
    void Update()
    {
        transform.Translate(Vector2.right * fltSpeed * Time.deltaTime);
    }
}
