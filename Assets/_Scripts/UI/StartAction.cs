using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartAction : MonoBehaviour {

	private int lastLevel;
	private int currentLevel;

	public void LoadMenu()  {
		SceneManager.LoadScene("Menu");
	}

	public void LoadLevelMenu()  {
		SceneManager.LoadScene("LevelMenu");
	}

	public void LoadExit()  {
		Application.Quit();
	}

	public void LoadLastLevel()  {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");

		if (lastLevel == 0) {
			SceneManager.LoadScene ("Instructions");
		} else {
			SceneManager.LoadScene (lastLevel);
		}
	}

	public void restart()  {
		currentLevel = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentLevel);
	}

	public void LoadLevel1Check()  {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");

		if (lastLevel == 0) {
			SceneManager.LoadScene ("Instructions");
		} else {
			SceneManager.LoadScene (1);
		}
	}

	public void LoadLevel1()  {
		SceneManager.LoadScene (1);
	}

	public void LoadLevel2()  {
		SceneManager.LoadScene(2);
	}

	public void LoadLevel3()  {
		SceneManager.LoadScene(3);
	}

	public void LoadLevel4()  {
		SceneManager.LoadScene(4);
	}

	public void LoadLevel5()  {
		SceneManager.LoadScene(5);
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
