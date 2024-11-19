using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Transform ShootPoint;

    public float FireRate;

    public GameObject ProjectilePrefab;

    private float _shootCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _shootCounter += Time.deltaTime;

        if (_shootCounter >= FireRate)
        {
            _shootCounter = 0f;
            FireProjectile();
        }
    }

    private void FireProjectile()
    {
        GameObject newProjectile = Instantiate(ProjectilePrefab);
        newProjectile.transform.position = ShootPoint.position;
        newProjectile.transform.forward = transform.forward;
    }
}
