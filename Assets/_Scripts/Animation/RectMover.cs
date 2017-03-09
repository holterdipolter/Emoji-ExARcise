using UnityEngine;
using System.Collections;

public class RectMover : MonoBehaviour {

	//public float AmplitudeX;
	//public float AmplitudeY;
	//public float Speed;


	public GameObject text;
	private Vector3 pos;
	private int richtung;
	public int speed=1;
	bool bewegung=false;
	int j=50;


	void Start () {
		
	}

	public void moveBack(){
		if (j > 50) {
			pos = transform.localPosition;
			if (pos.x < -1)
				bewegung = true;
			j = 0;
			richtung = 1;
			Debug.Log ("moveBack ");
		}
	}

	public void moveNext(){
		if (j > 50) {
			pos = transform.localPosition;
			if (pos.x > -3001)
				bewegung = true;
			j = 0;
			richtung = -1;
			Debug.Log ("moveNext ");
		}
	}



	void Update () {
		j++;

		if (j > 50)
			bewegung = false;

		if (bewegung) {
			pos.x = pos.x +20*richtung;
			transform.localPosition = pos;
		
		}


	}
}
