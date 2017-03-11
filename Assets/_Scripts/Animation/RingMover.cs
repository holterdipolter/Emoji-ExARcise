using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMover : MonoBehaviour {

	public float anzahlFrames;
	public float ringdurchmesserMin;
	public bool richtungNachInnen;
	public bool wiederZurueck;

	private Vector3 endScale;
	private Vector3 scaleStep;
	private Vector3 updateScale;

	private bool richtung = true;


	void Start () {

		endScale = transform.localScale;
		scaleStep = (endScale - new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1))/(anzahlFrames);


		if (richtungNachInnen == false) {
			transform.localScale = new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1);

		} else {
			transform.localScale = endScale;
		}

		if (wiederZurueck == true) {
			transform.localScale = new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1);
			richtungNachInnen = false;
		}

	}
	
	// Update is called once per frame
	void Update () {

		if (wiederZurueck == false) {
			if (richtungNachInnen == false) {

				updateScale = transform.localScale + scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;
			
				if (transform.localScale.x >= endScale.x) {
					transform.localScale = new Vector3 (ringdurchmesserMin, ringdurchmesserMin, 1);
				}
			
			}

			if (richtungNachInnen == true) {

				updateScale = transform.localScale - scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;

				if (transform.localScale.x <= ringdurchmesserMin) {
					transform.localScale = endScale;
				}

			}
		}

		if (wiederZurueck == true){

			if (richtung == true) {

				updateScale = transform.localScale + scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;

				if (transform.localScale.x >= endScale.x) {
					richtung = false;
				}
			}

			if (richtung == false) {

				updateScale = transform.localScale - scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;

				if (transform.localScale.x <= ringdurchmesserMin) {
					richtung = true;
				}
			}

		}
		
	}
}
