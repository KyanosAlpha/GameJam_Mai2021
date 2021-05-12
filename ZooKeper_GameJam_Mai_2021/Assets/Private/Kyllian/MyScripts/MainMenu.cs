using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	#region Utils
	
	public void PlayGame()
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