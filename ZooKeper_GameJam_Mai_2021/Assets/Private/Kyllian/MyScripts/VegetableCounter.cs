using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableCounter : MonoBehaviour
{
    #region Unity API

    private void Awake()
    {
        _vegetableScore.Value = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Vegetable"))
        {
            int point = other.gameObject.GetComponent<FoodValue>().GetPoint();

            _vegetableScore.Value += point;

            Destroy(other.gameObject);

            Debug.Log("Vegetable: " + _vegetableScore.Value);
        }
        else if (other.gameObject.CompareTag("Meat"))
        {
            Destroy(other.gameObject);
        }
    }

    #endregion


    #region Private And Protected Members

    [SerializeField] private IntVariable _vegetableScore;

    #endregion
}