using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenu : MonoBehaviour
{
	#region Utils
	
	public void PauseGame()
    {
		Time.timeScale = 0;
    }

	public void ResumeGame()
	{
		Time.timeScale = 1;
	}

	public void StartGame()
	{
		Debug.Log("Play");
		SceneManager.LoadScene(1);
	}

	public void Quitgame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}

	#endregion
}