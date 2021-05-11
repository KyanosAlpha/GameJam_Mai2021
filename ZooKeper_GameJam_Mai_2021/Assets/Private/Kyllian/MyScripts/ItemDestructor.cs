using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ItemDestructor : MonoBehaviour
{
	#region Unity API

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Meat") || other.gameObject.CompareTag("Vegetable"))
        {
            Destroy(other.gameObject);
        }
    }

    #endregion
}