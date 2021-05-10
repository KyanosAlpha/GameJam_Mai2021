using UnityEngine;

public class TurnCage : MonoBehaviour
{
    #region Public Members

    #endregion


    #region Unity API
    private void Awake()
    {
        InitializeOnAwake();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        _degreeOfRotate = new Vector3(0, _rotateValue, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _transform.Rotate(_degreeOfRotate);
        }
    }

    #endregion

    #region Utils

    private void InitializeOnAwake()
    {
        _transform = transform;
    }

    #endregion


    #region Private And Protected

    private Transform _transform;

    private Vector3 _degreeOfRotate;

    [SerializeField]
    private float _rotateValue;

    #endregion
}