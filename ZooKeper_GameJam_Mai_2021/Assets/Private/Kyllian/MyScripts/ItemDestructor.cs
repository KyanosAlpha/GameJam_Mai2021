using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ItemDestructor : MonoBehaviour
{
	#region Unity API

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Meat") || other.gameObject.CompareTag("Vegetable") || other.gameObject.CompareTag("Kibble") || other.gameObject.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
        }
    }

    #endregion
}