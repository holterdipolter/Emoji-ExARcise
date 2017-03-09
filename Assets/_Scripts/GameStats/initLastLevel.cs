using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initLastLevel : MonoBehaviour {

	private int lastLevel;

	void Start () {

		lastLevel = PlayerPrefs.GetInt ("lastLevel");

		if (lastLevel >= 1) {
		} else {
			lastLevel = 0;
			PlayerPrefs.SetInt ("lastLevel", lastLevel);
		}

	}
	
}
