using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorTest : MonoBehaviour
{	
	#region Unity API
	
	private void Awake()
	{
		_transform = GetComponent<Transform>();

		_minimumRotation = _transform.rotation;
		_maximumRotation = Quaternion.Euler(_transform.rotation.x, _transform.rotation.y, _transform.rotation.z);
	}

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
			_interpolate += 5f * Time.deltaTime;
        }
		else
        {
			_interpolate -= 5f * Time.deltaTime;
		}

		_interpolate = Mathf.Clamp(_interpolate, 0f, 1f);
		_transform.rotation = Quaternion.Slerp(_minimumRotation, _maximumRotation, _interpolate);
    }

	#endregion


	#region Utils



	#endregion


	#region Private And Protected Members

	private float _interpolate = 0f;
	private Transform _transform;
	private Quaternion _minimumRotation;
	private Quaternion _maximumRotation;

	#endregion
}