using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEmoji : MonoBehaviour {
	private Vector3 pos;
	private int zaehler;

	// Use this for initialization
	void Start () {
		pos.x = -18f;
		pos.y = Random.Range (-8.0f, 8.0f);

	}

	void bewegung(){
		
		pos = transform.localPosition;
		if (zaehler < 550) {
			pos.x = pos.x+0.2f;
		}
		}
		
	// Update is called once per frame
	void Update () {
		bewegung ();
		zaehler++;

		if (pos.x > 18f) {
			pos.x = -18f;
			pos.y = Random.Range (-8.0f, 8.0f);
			zaehler = 0;
		}
		transform.localPosition = pos;
	}
}
