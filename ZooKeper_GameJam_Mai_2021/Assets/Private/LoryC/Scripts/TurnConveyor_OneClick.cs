using UnityEngine;

public class TurnConveyor_OneClick : MonoBehaviour
{
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
    }

    private void RotateConveyor()
    {
        _degreeOfRotate = new Vector3(0, _rotateValue, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _transform.Rotate(_degreeOfRotate);
        }
    }

    #endregion


    #region Private And Protected

    private Transform _transform;

    private Vector3 _degreeOfRotate;

    [SerializeField]
    private float _rotateValue = 180f;

    #endregion
}