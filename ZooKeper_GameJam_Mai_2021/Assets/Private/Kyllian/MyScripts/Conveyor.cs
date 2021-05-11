using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Conveyor : MonoBehaviour
{
    #region Unity API
    
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

    public float GetSpeed()
    {
        return _speed;
    }

    #endregion


    #region Private And Protected Members

    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed = 2f;
    
    #endregion
}