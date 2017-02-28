using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LoadLevel : MonoBehaviour {

	private int level = 0;

	private GameObject[] levelObjects;

	void Awake() {

		levelObjects = GameObject.FindGameObjectsWithTag("unlocked").OrderBy( go => go.name ).ToArray();
							
	}

	void Start () {

		level = PlayerPrefs.GetInt("level");
		Debug.Log("loadedLevelState: " +level);

		foreach (GameObject element in levelObjects)
		{
			element.SetActive(false);
		}

		for (int i = 0; i<=level; i++){

			if (i == levelObjects.Length) {
				Debug.Log ("ArrayEnde");
			}

			levelObjects[i].SetActive(true);
			Debug.Log ("ActivatedLevel: " + i);

		}

	}

}
