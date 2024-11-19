using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
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
        if (other.attachedRigidbody != null && other.attachedRigidbody.CompareTag("Enemy") && other.attachedRigidbody.TryGetComponent(out EnemyHealth health))
        {
            health.DecreaseHealth(Damage);
            Destroy(gameObject);
             
        }
    }
}
