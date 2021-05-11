using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Conveyor : MonoBehaviour
{
    #region Unity API

    private void Awake()
    {
        if(_renderer == null) { _renderer = GetComponent<MeshRenderer>(); }
    }

    private void Update()
    {
        BeltAnimation();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Meat") || other.CompareTag("Vegetable"))
        {
            Transform otherTransform = other.GetComponent<Transform>();

            otherTransform.position = Vector3.MoveTowards(otherTransform.position, _endPoint.position, _speed * Time.deltaTime);
        }
    }

    #endregion


    #region Utils

    private void BeltAnimation()
    {
        float offset = Time.time * _speed * -0.48f;

        _renderer.material.SetTextureOffset("_MainTex", new Vector2(0f, offset));
    }

    #endregion


    #region Private And Protected Members

    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private MeshRenderer _renderer;

    #endregion
}