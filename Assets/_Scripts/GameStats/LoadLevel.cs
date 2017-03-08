using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	private int level = 0;

	private GameObject[] levelObjects;


	private Button levelObjectButton;


	void Start () {

		levelObjects = GameObject.FindGameObjectsWithTag("unlocked").OrderBy( go => go.name ).ToArray();

		level = PlayerPrefs.GetInt("level");
		Debug.Log("loadedLevelState: " +level);



		foreach (GameObject element in levelObjects)
		{
			//element.SetActive(false);
			
			levelObjectButton = element.GetComponent<Button>();
			Debug.Log ("TEST1");
			levelObjectButton.enabled = !levelObjectButton.enabled;

			levelObjectButton.interactable = false;
			Debug.Log ("TEST2");


					
			//levelObjectColor = element.GetComponent<Image>().Color;
			//levelObjectColor = new Color32(255,255,255,255);

			//levelObjectButton = element.GetComponent<Button>;
			//levelObjectButton.SetActive (false);


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
