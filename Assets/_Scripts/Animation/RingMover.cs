using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMover : MonoBehaviour {

	// fuehrt eine einfache Animation aus, bei dem ein Objekt
	// um einen angegebenen Wert bzw Geschwindigkeit verkleinert bzw vergoessert wird
	// Richtung ist einstellbar

	public float anzahlFrames;
	public float ringdurchmesserMin;
	public bool richtungNachInnen;
	public bool wiederZurueck;

	private Vector3 endScale;
	private Vector3 scaleStep;
	private Vector3 updateScale;

	private bool richtung = true;


	void Start () {

		// In Unity eingestellte Scale abspeichern
		endScale = transform.localScale;

		// berechnen, um welchen Wert das Objekt pro Frame skaliert wird
		scaleStep = (endScale - new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1))/(anzahlFrames);

		// wurde "Richtung nach innen" gewahelt -> setze gewählten Minimaldurchmesser
		if (richtungNachInnen == false) {
			transform.localScale = new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1);
		
		// wurde "Richtung nach aussen" gewahelt -> setze Maximaldurchmesser
		} else {
			transform.localScale = endScale;
		}

		// wurde "wiederZurueck" gewahelt -> setze gewählten Minimaldurchmesser
		if (wiederZurueck == true) {
			transform.localScale = new Vector3 (ringdurchmesserMin,ringdurchmesserMin,1);
			richtungNachInnen = false;
		}

	}
	

	void Update () {

		if (wiederZurueck == false) {
			// wurde "Richtung nach aussen" gewaehelt -> vergroessere Objecktgroesse um errechnete Skalierung/Frame
			if (richtungNachInnen == false) {

				updateScale = transform.localScale + scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;
			
				if (transform.localScale.x >= endScale.x) {
					transform.localScale = new Vector3 (ringdurchmesserMin, ringdurchmesserMin, 1);
				}
			
			}
			// wurde "Richtung nach innen" gewaehelt -> verringere Objecktgroesse um errechnete Skalierung/Frame
			if (richtungNachInnen == true) {

				updateScale = transform.localScale - scaleStep*Time.deltaTime*30;
				transform.localScale = updateScale;

				if (transform.localScale.x <= ringdurchmesserMin) {
					transform.localScale = endScale;
				}

			}
		}

		// wurde "wiederZurueck" gewaehelt -> aendere Bewgungsruchtung wenn Maximal-/Minimalgroesse erreicht

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
