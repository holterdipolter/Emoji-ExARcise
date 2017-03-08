using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	private int level = 0;

	private GameObject[] levelObjects;
	private Button levelObjectButton;
	private Text levelObjectButtonText;

	void Start () {

		levelObjects = GameObject.FindGameObjectsWithTag("ButtonLevel").OrderBy( go => go.name ).ToArray();

		level = PlayerPrefs.GetInt("level");
		Debug.Log("loadedLevelState: " +level);

		int i = 0;

		foreach (GameObject element in levelObjects)
		{
			if (i > level) {
				levelObjectButton = element.GetComponent<Button>();
				levelObjectButton.interactable = false;

				levelObjectButtonText = levelObjectButton.GetComponentInChildren<Text>();
				levelObjectButtonText.color = new Color32(0,0,0,100);

			}
			i++;


		}

	}

}
