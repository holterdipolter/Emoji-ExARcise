using UnityEngine;
using System.Collections;

public class RectMoverInstructions : MonoBehaviour {



	private Vector3 pos;
	private int richtung;

	bool bewegung=false;
	int j=40;

	public GameObject backButton;
	public GameObject nextButton;
	public GameObject playButton;
	public GameObject storyButton;
	public GameObject instrButton;

		void Start () {
		
	}

	public void moveBack(){
		if (j > 40) {
			pos = transform.localPosition;
			if (pos.x < -1)
				bewegung = true;


			j = 0;
			richtung = 1;
			Debug.Log ("moveBack ");
		}
	}

	public void moveNext(){
		if (j > 40) {

			pos = transform.localPosition;
			if (pos.x > -3001){
				bewegung = true;
		}
			
			j = 0;
			richtung = -1;
			Debug.Log ("moveNext ");
		}
	}
		

	void Update () {
		j++;

		if (j > 40)
			bewegung = false;

		if (bewegung) {
			pos.x = pos.x +25*richtung;
			transform.localPosition = pos;
		}
		if (pos.x < -3500) {
			nextButton.active = false;
			storyButton.active = true;
		} else {
			nextButton.active = true;
			storyButton.active = false;
		}
		if (pos.x > -500)
			backButton.SetActive (false);
		else
			backButton.SetActive (true);

		if (pos.x == -5000)
			backButton.SetActive (false);
		else
			backButton.SetActive (true);
	}
}
