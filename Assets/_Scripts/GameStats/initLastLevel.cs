using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initLastLevel : MonoBehaviour {

	// liest das in "PlayerPrefs" gespeicherte letzte Level aus
	// ist kein Wert gespeichert wird der Wert auf 0 gesetzt

	private int lastLevel;

	void Start () {
		//letztes Level auslesen
		lastLevel = PlayerPrefs.GetInt ("lastLevel");

		if (lastLevel >= 1) {
		} else {
			lastLevel = 0;
			PlayerPrefs.SetInt ("lastLevel", lastLevel);
		}

	}
	
}
