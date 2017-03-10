using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHeadline : MonoBehaviour {

	private Vector3 pos;
	private int richtung;

	bool bewegung=false;
	int j=25;

	public void move2Story(){
		if (j > 25) {
			pos = transform.localPosition;
			if (pos.x ==0)
				bewegung = true;
	
			j = 0;
			richtung = -1;
			Debug.Log ("moveStory");
		}
	}

	public void move2Instructions(){
		if (j > 25) {
			pos = transform.localPosition;
			if (pos.x == -1000){
				bewegung = true;
			}

			j = 0;
			richtung = +1;
			Debug.Log ("moveInstructions");
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		j++;

		if (j > 25)
			bewegung = false;

		if (bewegung) {
			pos.x = pos.x +40*richtung;
			transform.localPosition = pos;
		}


	}
}
