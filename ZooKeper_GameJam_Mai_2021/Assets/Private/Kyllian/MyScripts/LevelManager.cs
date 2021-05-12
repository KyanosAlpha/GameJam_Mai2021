using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
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
			_loseScreen.SetActive(true);
			StartCoroutine("RestartLevel");
		}
	}

	private void Win()
    {
		if (_meatScore.Value >= _maxMeat.Value && _vegetableScore.Value >= _maxVegetable.Value && !_isLevelEnd)
		{
			_isLevelEnd = true;
			_winScreen.SetActive(true);
			StartCoroutine("NextLevel");
		}
    }

	IEnumerator RestartLevel()
	{
		yield return new WaitForSeconds(4f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	IEnumerator NextLevel()
    {
		yield return new WaitForSeconds(4f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
	[SerializeField] private GameObject _loseScreen;
	[SerializeField] private GameObject _winScreen;

	#endregion
}