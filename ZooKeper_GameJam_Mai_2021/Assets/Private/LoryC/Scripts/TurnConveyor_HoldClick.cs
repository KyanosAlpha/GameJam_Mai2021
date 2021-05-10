using System;
using UnityEngine;

public class TurnConveyor_HoldClick : MonoBehaviour
{
    #region Public Members

    #endregion


    #region Unity API

    private void Awake()
    {
        InitializeOnAwake();
    }


    private void Update()
    {
        RotateConveyor();
    }

    #endregion


    #region Utils

    private void InitializeOnAwake()
    {
        _transform = transform;
        _baseRotation = _transform.rotation;
    }

    private void RotateConveyor()
    {
        _degreeOfRotate = new Vector3(0, _rotateValue, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _transform.Rotate(_degreeOfRotate);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _transform.rotation = _baseRotation;
        }
    }

    #endregion


    #region Private And Protected

    private Transform _transform;

    private Vector3 _degreeOfRotate;
    private Quaternion _baseRotation;

    [SerializeField]
    private float _rotateValue = 180f;

    #endregion
}