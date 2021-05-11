using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MeatCounter : MonoBehaviour
{
	#region Unity API
	
	private void Awake()
	{
        _meatScore.Value = 0;
    }
	
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Meat") || other.gameObject.CompareTag("Kibble") || other.gameObject.CompareTag("Trash"))
        {
            int point = other.gameObject.GetComponent<FoodValue>().GetPoint();

            _meatScore.Value += point;

            Destroy(other.gameObject);

            Debug.Log("Meat: " + _meatScore.Value);
        }
        else if(other.gameObject.CompareTag("Vegetable"))
        {
            Destroy(other.gameObject);
        }
    }

    #endregion


    #region Private And Protected Members

    [SerializeField] private IntVariable _meatScore;

    #endregion
}