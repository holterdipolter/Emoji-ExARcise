using UnityEngine;
using System.Collections;

public class RectMoverInstructions : MonoBehaviour {

	public GameObject BackButton;

	public GameObject text;
	private Vector3 pos;
	private int richtung;

	bool bewegung=false;
	int j=40;
	public GameObject nextButton;
	public GameObject playButton;

	void Start () {
		
	}

	public void moveBack(){
		if (j > 40) {
			pos = transform.localPosition;
			if (pos.x < -1)
				bewegung = true;
			else {
				BackButton.SetActive (false);
			}
			if (pos.x == -1000)
			BackButton.SetActive (false);
				j = 0;
			richtung = 1;
			Debug.Log ("moveBack ");
		}
	}

	public void moveNext(){
		if (j > 40) {
			BackButton.SetActive (true);
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
			playButton.active = true;
		} else {
			nextButton.active = true;
			playButton.active = false;
		}

	}
}
