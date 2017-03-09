using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

	public GameObject TriggerX1;
	public GameObject TriggerX2;
	public GameObject TriggerX3;
	public GameObject TriggerX4;

	private int level = 0;

	private GameObject[] levelObjects;
	private Button levelObjectButton;
	private Text levelObjectButtonText;
	private int i;


	void Start () {

		levelObjects = GameObject.FindGameObjectsWithTag("ButtonLevel").OrderBy( go => go.name ).ToArray();
		//TriggerX1.SetActive (true);

		level = PlayerPrefs.GetInt("level");
		Debug.Log("loadedLevelState: " +level);

		//TriggerX2.SetActive (true);

		i = 0;

		foreach (GameObject element in levelObjects)
		{

			if (i > level) {
				//TriggerX3.SetActive (true);

				levelObjectButton = element.GetComponent<Button>();				
				levelObjectButton.interactable = false;

				levelObjectButtonText = levelObjectButton.GetComponentInChildren<Text>();
				levelObjectButtonText.color = new Color32(0,0,0,100);

				//TriggerX4.SetActive (true);
			}

			i++;


		}

	}

}
