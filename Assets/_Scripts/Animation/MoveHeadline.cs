using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//bewegt die Überschrift in Instructions/Story


public class MoveHeadline : MonoBehaviour {

	private Vector3 pos; 
	private int richtung;

	bool bewegung=false;
	int j=25; //zählvariable

	//Story Überschrift komm rein
	public void move2Story(){
		//keine Bewegung, wenn Bewegung bereits gestartet
		if (j > 25) {
			pos = transform.localPosition;
			//nur bewegen, wenn an korrekter Position
			if (pos.x ==0)
				bewegung = true;
	
			//zurücksetzen des Zählers, sodass Bewegung möglich
			j = 0;
			//Bewegung nach rechts
			richtung = -1;

		}
	}
	//Instructions Überschrift komm rein
	public void move2Instructions(){
		//keine Bewegung, wenn Bewegung bereits gestartet
		if (j > 25) {
			pos = transform.localPosition;
			//nur bewegen, wenn an korrekter Position
			if (pos.x == -1000)
				bewegung = true;

			//zurücksetzen des Zählers, sodass Bewegung möglich
			j = 0;
			//Bewegung nach links
			richtung = +1;

		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		j++;
		//ausschalten der Bewegegung, wenn abgeschlossen
		if (j > 25)
			bewegung = false;

		//Verschieben der objekte
		if (bewegung) {
			pos.x = pos.x +40*richtung;
			transform.localPosition = pos;
		}


	}
}
