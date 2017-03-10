using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEmoji : MonoBehaviour {
	private Vector3 pos;
	private int zaehler;
	public bool upwards;
	public float speed;
	public float angle;
	int richtung;
	// Use this for initialization
	void Start () {
		if (upwards)
			richtung = 1;
		else
			richtung = -1;
		pos.x = -18f;
		pos.y = Random.Range (-8.0f, 8.0f);


	}

	void bewegung(){
		
		Debug.Log ("angle ist " + angle);
		pos = transform.localPosition;
		if (zaehler < 550) {
			pos.x = pos.x+richtung*angle*0.003f;
			pos.y = pos.y + richtung*speed*0.02f;
		}
		}
		
	// Update is called once per frame
	void Update () {
		bewegung ();
		zaehler++;

		if (pos.x > 18f||pos.y>10||pos.y<-10) {
			pos.x = Random.Range (-18.0f, 18.0f);;
			pos.y = 9.95f;
			zaehler = 0;
			angle = Random.Range (3f, 10f);
			speed = Random.Range (5f, 10f);
			//if (upwards)
			//	upwards = false;
			//else
			//	upwards = true;
		}
		transform.localPosition = pos;
	}
}
