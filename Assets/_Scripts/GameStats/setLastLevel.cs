using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setLastLevel : MonoBehaviour {

	// Aufruf des zuletzt geladenen levels (zum Auslesen durch den Resume Button)

	private int lastLevel;

	void Start () {

		lastLevel = SceneManager.GetActiveScene().buildIndex;

			PlayerPrefs.SetInt ("lastLevel", lastLevel);
	}
	
}
