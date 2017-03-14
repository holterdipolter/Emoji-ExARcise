using UnityEngine;
using System.Collections;

public class RectMoverInstructions : MonoBehaviour {

	//Steuerung der Textfelder/Buttons in Instruction/Story

	private Vector3 pos;
	private int richtung; //richtungsvariable

	bool bewegung=false; //Freischaltung der Bewegung
	int j=25; //Zählvariable

	public GameObject backButton;
	public GameObject nextButton;
	public GameObject playButton;
	public GameObject storyButton;
	public GameObject instrButton;

		void Start () {
		
	}

	//Bewegung nach links
	public void moveBack(){
		if (j > 25) {
			pos = transform.localPosition;
			//wenn nicht an endposition
			if (pos.x < -1)
				bewegung = true;


			j = 0;
			richtung = 1;
			Debug.Log ("moveBack ");
		}
	}
	//Bewegung nach rechts
	public void moveNext(){
		if (j > 25) {

			pos = transform.localPosition;
			//wenn nicht an endposition
			if (pos.x > -8001){
				bewegung = true;
		}
			
			j = 0;
			richtung = -1;
			Debug.Log ("moveNext ");
		}
	}
		

	void Update () {
		j++; 

		//Beenden einer Bewegung
		if (j > 25)
			bewegung = false;
		//Eigentliche Bewegung
		if (bewegung) {
			pos.x = pos.x +40*richtung;
			transform.localPosition = pos;
		}

		//ein/ausblenden nextbutton
		if (pos.x <= 0 && pos.x > -3500 || pos.x < -4500 && pos.x > -8500)
			nextButton.SetActive (true);
		else
			nextButton.SetActive (false);
		//ein/ausblenden backbutton
		if (pos.x < -500 && pos.x > -4500 || pos.x < -5500)
			backButton.SetActive (true);
		else
			backButton.SetActive (false);
		//ein/ausblenden playbutton
		if (pos.x < -8500)
			playButton.SetActive (true);
		else
			playButton.SetActive (false);
		//ein/ausblenden instructionsbutton
		if (pos.x > -5500 && pos.x < -4500)
			instrButton.SetActive (true);
		else
			instrButton.SetActive (false);
		//ein/ausblenden storybutton
		if (pos.x > -4500 && pos.x < -3500)
			storyButton.SetActive (true);
		else
			storyButton.SetActive (false);
			


	}
}
