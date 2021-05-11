using System.Collections;
using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
	#region Unity API
	
	private void Awake()
	{
		_maxMeat.Value = _winMeatAmount;
		_maxVegetable.Value = _winVegetableAmount;
	}

    private void Update()
    {
		Lose();
		Win();
	}

	#endregion


	#region Utils

	private void Lose()
	{
		if (_timeRemaining.Value <= 0 && !_isLevelEnd)
		{
			_isLevelEnd = true;
			Debug.Log("Lose");
			StartCoroutine("RestartLevel");
		}
	}

	private void Win()
    {
		if (_meatScore.Value >= _maxMeat.Value && _vegetableScore.Value >= _maxVegetable.Value && !_isLevelEnd)
		{
			_isLevelEnd = true;
			Debug.Log("Win");
			StartCoroutine("NextLevel");
		}
    }

	IEnumerator RestartLevel()
	{
		yield return new WaitForSeconds(4f);
		Debug.Log("Restart Level");
	}

	IEnumerator NextLevel()
    {
		yield return new WaitForSeconds(4f);
		Debug.Log("Next Level");
	}

	#endregion


	#region Private And Protected Members

	private bool _isLevelEnd = false;
	[SerializeField] private int _winMeatAmount = 10;
	[SerializeField] private int _winVegetableAmount = 10;
	[SerializeField] private FloatVariable _timeRemaining;
	[SerializeField] private IntVariable _meatScore;
	[SerializeField] private IntVariable _vegetableScore;
	[SerializeField] private IntVariable _maxMeat;
	[SerializeField] private IntVariable _maxVegetable;

	#endregion
}