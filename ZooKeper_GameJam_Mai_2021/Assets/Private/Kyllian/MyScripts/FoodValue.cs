using UnityEngine;

public class FoodValue : MonoBehaviour
{
	#region Public members
	
	public int GetPoint()
    {
		return _point;
    }
	
	#endregion


	#region Private And Protected Members

	[SerializeField] private int _point = 1;
	
	#endregion
}