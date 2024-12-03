using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [SerializeField] private Transform _ground;
    [SerializeField] private float _groundSpeed;

    [SerializeField] private Vector3 _groundMoveDirection;

    private bool _isMoving;

    private void Start()
    {
        StartGroundMove();
    }
    
    private void Update()
    {
        if (!_isMoving) return;
        
        Vector3 moveAmount = _groundMoveDirection * (_groundSpeed * Time.deltaTime);
        
        _ground.position += moveAmount;
        
    }

    #region Ground Movement Interface
    
    public void StartGroundMove()
    {
        _isMoving = true;
    }

    public void StopGroundMove()
    {
        _isMoving = false;
    }
    
    #endregion
}
