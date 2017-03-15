using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	// ueberprueft welche Level bereits erfolgreich absolviert wurden
	// stellt entspechend alle Level-Buttons im Level-Menu auf "active"

	private int level = 0;

	private GameObject[] levelObjects;
	private Button levelObjectButton;
	private Text levelObjectButtonText;
	private int i;


	void Start () {

		// speichere alle Level-Buttons in einem Array, sortiere aufsteigend nach Namen
		levelObjects = GameObject.FindGameObjectsWithTag("ButtonLevel").OrderBy( go => go.name ).ToArray();

		// lese das in PlayerPrefs gespeicherte letzte Level aus
		level = PlayerPrefs.GetInt("level");
		Debug.Log("loadedLevelState: " +level);

		i = 0;

		foreach (GameObject element in levelObjects)
		{
			// Level-Buttons der Level auf "active" setzen, die bereits gespielt wurden
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
