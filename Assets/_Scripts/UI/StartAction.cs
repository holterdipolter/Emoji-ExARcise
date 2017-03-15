using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DigitalRuby.SoundManagerNamespace;

//Scenenwechsel

public class StartAction : MonoBehaviour {

	private int lastLevel;
	private int currentLevel;
	public AudioSoundManager soundmanager;
	public void LoadMenu()  {
		SceneManager.LoadScene("Menu");
	}
	//normaler Levelmenuaufruf
	public void LoadLevelMenu()  {
		SceneManager.LoadScene("LevelMenu");
	}
	//Levelmenuaufruf aus Hauptmenu, Überprüfung, ob schon ein Level gespielt wurde
	public void LoadLevelMenuCheck()  {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");
		//wenn noch kein Level gespielt, erst Instructions laden
		if (lastLevel == 0) {
			SceneManager.LoadScene ("Instructions");
			soundmanager.PlayMusic (2);
		} else {
			SceneManager.LoadScene ("LevelMenu");
		}
	}
	//Schließen
	public void LoadExit()  {
		Application.Quit();
	}

	//aus den PalyerPrefs das zuletzt gestartete Level auslesen
	public void LoadLastLevel()  {
		lastLevel = PlayerPrefs.GetInt ("lastLevel");

		if (lastLevel == 0) {
			SceneManager.LoadScene ("Instructions");
		} else {
			SceneManager.LoadScene (lastLevel);
		}
	}
	//Levelrestart
	public void restart()  {
		currentLevel = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (currentLevel);
	}

	//Levelaufrufe anhand der Indizes
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

	public void LoadLevel6()  {
		SceneManager.LoadScene(6);
	}

	public void LoadLevel7()  {
		SceneManager.LoadScene(7);
	}

	public void LoadLevel8()  {
		SceneManager.LoadScene(8);
	}

	public void LoadLevel9()  {
		SceneManager.LoadScene(9);
	}

	public void LoadLevel10()  {
		SceneManager.LoadScene(10);
	}

	public void LoadLevel11()  {
		SceneManager.LoadScene(11);
	}

	public void LoadLevel12()  {
		SceneManager.LoadScene(12);
	}

	public void LoadLevel13()  {
		SceneManager.LoadScene(13);
	}

	public void LoadLevel14()  {
		SceneManager.LoadScene(14);
	}

	public void LoadLevel15()  {
		SceneManager.LoadScene(15);
	}

	public void LoadLevel16()  {
		SceneManager.LoadScene(16);
	}

	public void LoadInstructions()  {
		SceneManager.LoadScene("Instructions");
	}

	public void LoadStory()  {
		SceneManager.LoadScene("Story");
	}

	// die in PlayerPrefs gespeicherten Wert löschen
	public void DeletePrefs()  {
		PlayerPrefs.DeleteAll();
	}

}
