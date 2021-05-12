using UnityEngine;

public class AudioManager : MonoBehaviour
{
	#region Unity API
	
	private void Awake()
	{
		DontDestroyOnLoad(this);
	}
	
	#endregion
}