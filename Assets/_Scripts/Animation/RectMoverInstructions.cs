using UnityEngine;
using System.Collections;

public class RectMoverInstructions : MonoBehaviour {



	private Vector3 pos;
	private int richtung;

	bool bewegung=false;
	int j=25;

	public GameObject backButton;
	public GameObject nextButton;
	public GameObject playButton;
	public GameObject storyButton;
	public GameObject instrButton;

		void Start () {
		
	}


	public void moveBack(){
		if (j > 25) {
			pos = transform.localPosition;
			if (pos.x < -1)
				bewegung = true;


			j = 0;
			richtung = 1;
			Debug.Log ("moveBack ");
		}
	}

	public void moveNext(){
		if (j > 25) {

			pos = transform.localPosition;
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


		if (j > 25)
			bewegung = false;

		if (bewegung) {
			pos.x = pos.x +40*richtung;
			transform.localPosition = pos;
		}

		/*if (pos.x < -3500 || pos.x > -4500) {
			nextButton.SetActive (false);
			storyButton.SetActive (true);
		} else {
			nextButton.SetActive (true);
			storyButton.SetActive (false);
		}*/

		if (pos.x <= 0 && pos.x > -3500 || pos.x < -4500 && pos.x > -8500)
			nextButton.SetActive (true);
		else
			nextButton.SetActive (false);

		if (pos.x < -500 && pos.x > -4500 || pos.x < -5500)
			backButton.SetActive (true);
		else
			backButton.SetActive (false);

		if (pos.x < -8500)
			playButton.SetActive (true);
		else
			playButton.SetActive (false);

		if (pos.x > -5500 && pos.x < -4500)
			instrButton.SetActive (true);
		else
			instrButton.SetActive (false);

		if (pos.x > -4500 && pos.x < -3500)
			storyButton.SetActive (true);
		else
			storyButton.SetActive (false);
			


	}
}
