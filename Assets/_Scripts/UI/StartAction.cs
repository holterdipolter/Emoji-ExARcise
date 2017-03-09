using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAction : MonoBehaviour {

	public void LoadMenu()  {
		SceneManager.LoadScene("Menu");
	}
	public void LoadLevelMenu()  {
		SceneManager.LoadScene("LevelMenu");
	}
	public void LoadExit()  {
		Application.Quit();
	}
	public void LoadGame()  {
		SceneManager.LoadScene("Game");
	}
	public void LoadLevel1()  {
		SceneManager.LoadScene("Level1");
	}
	public void LoadLevel2()  {
		SceneManager.LoadScene("Level2");
	}
	public void LoadLevel3()  {
		SceneManager.LoadScene("Level3");
	}
	public void LoadInstructions()  {
		SceneManager.LoadScene("Instructions");
	}
	public void LoadStory()  {
		SceneManager.LoadScene("Story");
		Debug.Log ("StoryLoad");
	}
	public void DeletePrefs()  {
		PlayerPrefs.DeleteAll();
	}

}
