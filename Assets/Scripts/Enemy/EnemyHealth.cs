using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float MaximumHealth;
    
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = MaximumHealth;
    }

    public void DecreaseHealth(float amount)
    {
        _currentHealth -= amount;
        //if (_currentHealth <= 0) Destroy(gameObject);
    }
}
