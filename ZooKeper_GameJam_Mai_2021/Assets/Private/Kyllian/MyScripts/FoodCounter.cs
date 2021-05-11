using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FoodCounter : MonoBehaviour
{
	#region Unity API
	
	private void Awake()
	{
        _meatScore.Value = 0;
        _vegetableScore.Value = 0;
    }
	
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Meat"))
        {
            int point = other.gameObject.GetComponent<FoodValue>().GetPoint();

            _meatScore.Value += point;
            Debug.Log("Meat: " + _meatScore.Value);
            Destroy(other.gameObject);
        }
        else if(other.CompareTag("Vegetable"))
        {
            int point = other.gameObject.GetComponent<FoodValue>().GetPoint();

            _vegetableScore.Value += point;
            Debug.Log("Vegetable: " + _vegetableScore.Value);
            Destroy(other.gameObject);
        }
    }

    #endregion


    #region Private And Protected Members

    [SerializeField] private IntVariable _meatScore;
    [SerializeField] private IntVariable _vegetableScore;

    #endregion
}