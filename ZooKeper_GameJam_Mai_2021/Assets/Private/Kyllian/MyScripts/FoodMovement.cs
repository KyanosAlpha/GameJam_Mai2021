using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
	#region Unity API

	private void Awake()
	{
		if (_rigidbody == null) { _rigidbody = GetComponent<Rigidbody>(); }
		if(_transform == null) { _transform = GetComponent<Transform>(); }
	}

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    #endregion


    #region Utils

    private void Move()
    {
        Vector3 direction = _transform.forward;
        Vector3 velocity = direction * _speed;
        Vector3 translation = velocity * Time.fixedDeltaTime;
        Vector3 newPosition = _transform.position + translation;

        _rigidbody.MovePosition(newPosition);
    }

    #endregion


    #region Private And Protected Members

    private Rigidbody _rigidbody;
	private Transform _transform;
    private float _speed = 2f;

	#endregion
}