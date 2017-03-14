using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FLiegenden Emojis im Hauptmenu

public class FlyingEmoji : MonoBehaviour {
	private Vector3 pos;

	public bool upwards;
	public float speed;
	public float angle;
	int richtung;

	void Start () {
		if (upwards)
			richtung = 1;
		else
			richtung = -1;
		pos.x = -18f;
		pos.y = Random.Range (-8.0f, 8.0f);
	}
	//bewegung nach unten
	void bewegung(){
		pos = transform.localPosition;
		pos.x = pos.x + richtung*angle*0.003f;
		pos.y = pos.y + richtung*speed*Time.deltaTime*0.6f;
	}
		

	void Update () {
		bewegung ();
		//zurücksetzen, wenn aus Spielfeld heraus
		if (pos.x < -18f||pos.x > 18f||pos.y>12||pos.y<-12) {
			pos.x = Random.Range (-18.0f, 18.0f);;
			pos.y = 9.95f;

			//angle = Random.Range (3f, 10f);
			angle = Random.Range (-10f, 10f);
			speed = Random.Range (5f, 10f);

		}
		transform.localPosition = pos;
	}
}
