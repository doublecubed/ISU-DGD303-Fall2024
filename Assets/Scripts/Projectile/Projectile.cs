using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask HitMask;
    
    public float Speed;
    public float Damage;
    
    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.position += transform.forward * (Speed * Time.deltaTime);
        
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody == null) return;
        if (!other.attachedRigidbody.CompareTag("Enemy")) return;
        if (!other.attachedRigidbody.TryGetComponent(out EnemyHealth health)) return;
        
        health.DecreaseHealth(Damage);
        Destroy(gameObject);
            
    }
}
