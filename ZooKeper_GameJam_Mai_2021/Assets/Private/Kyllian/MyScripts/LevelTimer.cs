using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    #region Unity API

    private void Awake()
    {
		_levelTimer.Value = _loseTime;
	}

    private void Update()
    {
		TimeDecrease();
	}

	#endregion


	#region Utils

	private void TimeDecrease()
    {
		if (!(_levelTimer.Value > 0)) return;

		_levelTimer.Value -= Time.deltaTime;

		_levelTimer.Value = Mathf.Clamp(_levelTimer.Value, 0f, _loseTime);
	}

	#endregion


	#region Private And Protected Members

	[SerializeField] private FloatVariable _levelTimer;
	[SerializeField] private float _loseTime = 10f;
	
	#endregion
}